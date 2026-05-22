using Catalog.Api.Config;
using Catalog.Application.Events;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;


using System.Text;
using System.Text.Json;

namespace Catalog.Api.Messaging;

public class BookInteractionPublisher
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<BookInteractionPublisher> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public BookInteractionPublisher(IOptions<RabbitMQSettings> settings, ILogger<BookInteractionPublisher> logger)
    {
        _settings = settings.Value;
        _logger = logger;
    }

    private async Task InitializeRabbitMQAsync()
    {
        if (_channel != null) return;

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
    }

    public async Task PublishUserInteractionAsync(UserInteractionEvent @event)
    {
        try
        {
            await InitializeRabbitMQAsync();

            if (_channel == null)
            {
                throw new InvalidOperationException("RabbitMQ channel is not initialized.");
            }

            var message = JsonSerializer.Serialize(@event);
            var body = Encoding.UTF8.GetBytes(message);

            var properties = new BasicProperties
            {
                Persistent = true
            };

            await _channel.BasicPublishAsync(
                exchange: _settings.UserEventExchangeName,
                routingKey: _settings.UserEventRoutingKeyName,
                mandatory: true,
                basicProperties: properties,
                body: body);

            _logger.LogInformation("Interaccion de Usuario {Event} publicado en RabbitMQ (Exchange: {Exchange}, RoutingKey: {RoutingKey})",
                @event.InteractionType, _settings.UserEventExchangeName, _settings.UserEventRoutingKeyName);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al publicar NewBookBatchEvent en RabbitMQ");
            throw;
        }
    }


}
