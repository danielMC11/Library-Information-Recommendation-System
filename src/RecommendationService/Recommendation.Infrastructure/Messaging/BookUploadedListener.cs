using Microsoft.Extensions.Options;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Shared.Config;
using Shared.Events;
using Recommendation.Application.Services;
using Recommendation.Infrastructure.Persistence;
using Recommendation.Infrastructure.Services;
using System.Text;
using System.Text.Json;

namespace Recommendation.Api.Messaging;

public class BookUploadedListener : BackgroundService
{
    private readonly RabbitMQSettings _settings;
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly ILogger<BookUploadedListener> _logger;

    public BookUploadedListener(
        IOptions<RabbitMQSettings> settings,
        ILogger<BookUploadedListener> logger,
        IServiceScopeFactory scopeFactory)
    {
        _settings = settings.Value;
        _logger = logger;
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var initScope = _scopeFactory.CreateScope();
        var dbContext = initScope.ServiceProvider.GetRequiredService<RecommendationDbContext>();

        var resumeAtStr = await dbContext.SystemConfig
            .Where(e => e.Key == "GeminiResumeAtUtc")
            .Select(e => e.Value)
            .FirstOrDefaultAsync(stoppingToken);

        if (!string.IsNullOrEmpty(resumeAtStr) && DateTime.TryParse(resumeAtStr, out var resumeAt))
        {
            var colombiaNow = DateTime.UtcNow.AddHours(-5);
            if (resumeAt > colombiaNow)
            {
                var delay = resumeAt - colombiaNow;
                _logger.LogWarning("ResumeAtUtc is in the future ({ResumeAt}). Delaying for {Delay} before subscribing.",
                    resumeAt, delay);
                await Task.Delay(delay, stoppingToken);
            }
        }

        await SubscribeAsync(stoppingToken);

        await Task.Delay(Timeout.Infinite, stoppingToken);
    }

    private async Task SubscribeAsync(CancellationToken stoppingToken)
    {
        using var cleanupScope = _scopeFactory.CreateScope();
        var cleanupDb = cleanupScope.ServiceProvider.GetRequiredService<RecommendationDbContext>();
        var entry = await cleanupDb.SystemConfig
            .FirstOrDefaultAsync(e => e.Key == "GeminiResumeAtUtc", stoppingToken);
        if (entry != null)
        {
            cleanupDb.SystemConfig.Remove(entry);
            await cleanupDb.SaveChangesAsync(stoppingToken);
            _logger.LogInformation("Cleared stale GeminiResumeAtUtc from SystemConfig");
        }

        var factory = new ConnectionFactory
        {
            HostName = _settings.HostName,
            Port = _settings.Port,
            UserName = _settings.UserName,
            Password = _settings.Password,
            VirtualHost = _settings.VirtualHost
        };

        var connection = await factory.CreateConnectionAsync();
        var channel = await connection.CreateChannelAsync(cancellationToken: stoppingToken);

        await channel.BasicQosAsync(prefetchSize: 0, prefetchCount: 1, global: false, cancellationToken: stoppingToken);

        var consumer = new AsyncEventingBasicConsumer(channel);
        consumer.ReceivedAsync += async (_, ea) =>
        {
            await OnMessageReceivedAsync(channel, ea, stoppingToken);
        };

        await channel.BasicConsumeAsync(
            queue: _settings.Events.BooksUploaded.Queue,
            autoAck: false,
            consumer: consumer,
            cancellationToken: stoppingToken);

        _logger.LogInformation("BookUploadedListener subscribed to queue {Queue}", _settings.Events.BooksUploaded.Queue);
    }

    private async Task OnMessageReceivedAsync(IChannel channel, BasicDeliverEventArgs ea, CancellationToken stoppingToken)
    {
        var body = ea.Body.ToArray();
        var json = Encoding.UTF8.GetString(body);

        try
        {
            var @event = JsonSerializer.Deserialize<BookUploadedEvent>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (@event is null)
            {
                _logger.LogWarning("Deserialized event is null. Body: {Json}", json);
                await channel.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: false, cancellationToken: stoppingToken);
                return;
            }

            var estimatedTokens = @event.Description?.Length / 4 ?? 0;

            using var scope = _scopeFactory.CreateScope();
            var rateLimitTracker = scope.ServiceProvider.GetRequiredService<RateLimitTracker>();

            var (wouldExceed, resumeAtUtc) = await rateLimitTracker.CheckAndUpdateLimitsAsync(estimatedTokens);

            if (wouldExceed && resumeAtUtc.HasValue)
            {
                _logger.LogWarning("Rate limit would be exceeded. Pausing and requeueing. Resume at {ResumeAt}", resumeAtUtc.Value);
                await PauseAndRequeueAsync(channel, ea, resumeAtUtc.Value, stoppingToken);
                return;
            }

            var bookVectorService = scope.ServiceProvider.GetRequiredService<BookVectorService>();
            await bookVectorService.ProcessEmbeddingAsync(@event);

            await channel.BasicAckAsync(ea.DeliveryTag, multiple: false, cancellationToken: stoppingToken);
            _logger.LogInformation("Processed and acknowledged book {BookId}", @event.Id);
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "Error deserializing message: {Json}", json);
            await channel.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: false, cancellationToken: stoppingToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing BookUploadedEvent");
            await channel.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: true, cancellationToken: stoppingToken);
        }
    }

    private async Task PauseAndRequeueAsync(IChannel channel, BasicDeliverEventArgs ea, DateTime resumeAtUtc, CancellationToken stoppingToken)
    {
        using var scope = _scopeFactory.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<RecommendationDbContext>();

        var configEntry = await dbContext.SystemConfig
            .FirstOrDefaultAsync(e => e.Key == "GeminiResumeAtUtc", stoppingToken);

        if (configEntry == null)
        {
            dbContext.SystemConfig.Add(new SystemConfigEntry
            {
                Key = "GeminiResumeAtUtc",
                Value = resumeAtUtc.ToString("o")
            });
        }
        else
        {
            configEntry.Value = resumeAtUtc.ToString("o");
        }

        await dbContext.SaveChangesAsync(stoppingToken);

        var consumerTag = ea.ConsumerTag;
        await channel.BasicCancelAsync(consumerTag, cancellationToken: stoppingToken);
        await channel.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: true, cancellationToken: stoppingToken);

        _logger.LogWarning("Paused consumption. Consumer cancelled, message requeued. Will resume at {ResumeAt}", resumeAtUtc);

        _ = Task.Run(async () =>
        {
            var colombiaNow = DateTime.UtcNow.AddHours(-5);
            if (resumeAtUtc > colombiaNow)
            {
                var delay = resumeAtUtc - colombiaNow;
                _logger.LogWarning("Will resume subscription at {ResumeAt} (in {Delay})", resumeAtUtc, delay);
                await Task.Delay(delay, stoppingToken);
            }

            if (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogWarning("Resuming subscription after rate limit pause...");
                await SubscribeAsync(stoppingToken);
            }
        }, stoppingToken);
    }

    public override void Dispose()
    {
        base.Dispose();
    }
}
