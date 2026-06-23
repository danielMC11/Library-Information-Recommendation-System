using Microsoft.Extensions.Options;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Shared.Config;
using Shared.Events;
using Recommendation.Application.Services;
using System.Text;
using System.Text.Json;


namespace Recommendation.Api.Messaging;

public class BooksUploadedListener : BackgroundService
{
    private readonly RabbitMQSettings _settings;
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly ILogger<BooksUploadedListener> _logger;
    private IConnection? _connection;
    private IChannel? _channel;


    public BooksUploadedListener(
        IOptions<RabbitMQSettings> settings,
        ILogger<BooksUploadedListener> logger,
        IServiceScopeFactory scopeFactory
        )
    {
        _settings = settings.Value;
        _logger = logger;
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var factory = new ConnectionFactory
        {
            HostName = _settings.HostName,
            Port = _settings.Port,
            UserName = _settings.UserName,
            Password = _settings.Password,
            VirtualHost = _settings.VirtualHost
        };

        _connection = await factory.CreateConnectionAsync();
        _channel = await _connection.CreateChannelAsync();

        await _channel.BasicQosAsync(prefetchSize: 0, prefetchCount: 1, global: false);

        var consumer = new AsyncEventingBasicConsumer(_channel);

        consumer.ReceivedAsync += async (_, ea) =>
        {
            var body = ea.Body.ToArray();
            var json = Encoding.UTF8.GetString(body);

            try
            {
                var @event = JsonSerializer.Deserialize<BooksUploadedEvent>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (@event is null)
                {
                    _logger.LogWarning("Evento deserializado es null. Body: {Json}", json);
                    await _channel.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: false);
                    return;
                }

                _logger.LogInformation("Recibido BooksUploadedEvent con {Count} libros", @event.Books.Count);

                using var scope = _scopeFactory.CreateScope();
                var processService = scope.ServiceProvider.GetRequiredService<ProcessBooksBatchService>();
                await processService.ProcessEmbeddingsAsync(@event);

                await _channel.BasicAckAsync(ea.DeliveryTag, multiple: false);
            }
            catch (JsonException ex)
            {
                _logger.LogError(ex, "Error deserializando mensaje: {Json}", json);
                await _channel.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error procesando BooksUploadedEvent");
                await _channel.BasicNackAsync(ea.DeliveryTag, multiple: false, requeue: true);
            }
        };

        await _channel.BasicConsumeAsync(
            queue: _settings.Events.BooksUploaded.Queue,
            autoAck: false,
            consumer: consumer
        );

        await Task.Delay(Timeout.Infinite, stoppingToken);
    }

    public override void Dispose()
    {
        _channel?.Dispose();
        _connection?.Dispose();
        base.Dispose();
    }
}
