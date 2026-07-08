using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Shared.Config;
using Shared.Helpers;
using Recommendation.Application.Interfaces;
using Recommendation.Infrastructure.Persistence;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace Recommendation.Infrastructure.Messaging;

public abstract class RateLimitedRabbitListenerBase<TEvent> : BackgroundService
{
    protected readonly RabbitMQSettings _settings;
    protected readonly IServiceScopeFactory _scopeFactory;
    protected readonly ILogger _logger;
    protected IConnection? _connection;
    protected IChannel? _channel;

    protected abstract string QueueName { get; }
    protected abstract string ResumeConfigKey { get; }
    protected abstract int EstimateTokens(TEvent @event);
    protected abstract Task ProcessMessageAsync(TEvent @event, IServiceScope scope);

    protected RateLimitedRabbitListenerBase(
        IOptions<RabbitMQSettings> settings,
        ILogger logger,
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
            .Where(e => e.Key == ResumeConfigKey)
            .Select(e => e.Value)
            .FirstOrDefaultAsync(stoppingToken);

        if (!string.IsNullOrEmpty(resumeAtStr) && DateTime.TryParseExact(resumeAtStr, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var resumeAt))
        {
            var now = ColombiaTimeHelper.Now;
            if (resumeAt > now)
            {
                var delay = resumeAt - now;
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
        var deleted = await cleanupDb.SystemConfig
            .Where(e => e.Key == ResumeConfigKey)
            .ExecuteDeleteAsync(stoppingToken);
        if (deleted > 0)
        {
            _logger.LogInformation("Cleared stale {ResumeConfigKey} from SystemConfig", ResumeConfigKey);
        }

        var factory = new ConnectionFactory
        {
            HostName = _settings.HostName,
            Port = _settings.Port,
            UserName = _settings.UserName,
            Password = _settings.Password,
            VirtualHost = _settings.VirtualHost
        };

        _connection = await factory.CreateConnectionAsync(stoppingToken);
        _channel = await _connection.CreateChannelAsync(cancellationToken: stoppingToken);

        await _channel.BasicQosAsync(prefetchSize: 0, prefetchCount: 1, global: false, cancellationToken: stoppingToken);

        var consumer = new AsyncEventingBasicConsumer(_channel);
        consumer.ReceivedAsync += async (_, ea) =>
        {
            await OnMessageReceivedAsync(ea, stoppingToken);
        };

        await _channel.BasicConsumeAsync(
            queue: QueueName,
            autoAck: false,
            consumer: consumer,
            cancellationToken: stoppingToken);

        _logger.LogInformation("{ListenerName} subscribed to queue {Queue}", GetType().Name, QueueName);
    }

    private async Task OnMessageReceivedAsync(BasicDeliverEventArgs ea, CancellationToken stoppingToken)
    {
        var body = ea.Body.ToArray();
        var json = Encoding.UTF8.GetString(body);

        try
        {
            var evt = JsonSerializer.Deserialize<TEvent>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (evt is null)
            {
                _logger.LogWarning("Deserialized event is null. Body: {Json}", json);
                await _channel!.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: false, cancellationToken: stoppingToken);
                return;
            }

            var estimatedTokens = EstimateTokens(evt);

            using var scope = _scopeFactory.CreateScope();
            var rateLimitTracker = scope.ServiceProvider.GetRequiredService<IRateLimitTracker>();

            var (wouldExceed, resumeAtUtc) = await rateLimitTracker.CheckAndUpdateLimitsAsync(estimatedTokens);

            if (wouldExceed && resumeAtUtc.HasValue)
            {
                _logger.LogWarning("Rate limit would be exceeded. Pausing and requeueing. Resume at {ResumeAt}", resumeAtUtc.Value);
                await PauseAndRequeueAsync(ea, resumeAtUtc.Value, stoppingToken);
                return;
            }

            await ProcessMessageAsync(evt, scope);

            await _channel!.BasicAckAsync(ea.DeliveryTag, multiple: false, cancellationToken: stoppingToken);
            _logger.LogInformation("Processed and acknowledged event");
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "Error deserializing message: {Json}", json);
            await _channel!.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: false, cancellationToken: stoppingToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing event");
            await _channel!.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: true, cancellationToken: stoppingToken);
        }
    }

    private async Task PauseAndRequeueAsync(BasicDeliverEventArgs ea, DateTime resumeAtUtc, CancellationToken stoppingToken)
    {
        using var scope = _scopeFactory.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<RecommendationDbContext>();

        var configEntry = await dbContext.SystemConfig
            .FirstOrDefaultAsync(e => e.Key == ResumeConfigKey, stoppingToken);

        if (configEntry == null)
        {
            dbContext.SystemConfig.Add(new SystemConfigEntry
            {
                Key = ResumeConfigKey,
                Value = resumeAtUtc.ToString("yyyy-MM-ddTHH:mm:ss")
            });
        }
        else
        {
            configEntry.Value = resumeAtUtc.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        await dbContext.SaveChangesAsync(stoppingToken);

        var consumerTag = ea.ConsumerTag;
        await _channel!.BasicCancelAsync(consumerTag, cancellationToken: stoppingToken);
        await _channel.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: true, cancellationToken: stoppingToken);

        _logger.LogWarning("Paused consumption. Consumer cancelled, message requeued. Will resume at {ResumeAt}", resumeAtUtc);

        _ = Task.Run(async () =>
        {
            var now = ColombiaTimeHelper.Now;
            if (resumeAtUtc > now)
            {
                var delay = resumeAtUtc - now;
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
        _channel?.Dispose();
        _connection?.Dispose();
        base.Dispose();
    }
}
