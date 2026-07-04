using Shared.Config;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using Shared.Events;
using System.Text;
using System.Text.Json;
using Catalog.Application.Interfaces;

namespace Catalog.Infrastructure.Messaging;

public class BookUploadedPublisher : IBookUploadedPublisher
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<BookUploadedPublisher> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public BookUploadedPublisher(IOptions<RabbitMQSettings> settings, ILogger<BookUploadedPublisher> logger)
    {
        _settings = settings.Value;
        _logger = logger;
    }

    private async Task InitializeRabbitMQAsync()
    {
        if (_channel != null && _channel.IsOpen) return;

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

    public async Task PublishAsync(BookUploadedEvent @event)
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
                exchange: _settings.Exchanges.Catalog,
                routingKey: _settings.Events.BooksUploaded.RoutingKey,
                mandatory: true,
                basicProperties: properties,
                body: body);

            _logger.LogInformation("Libro {BookId} publicado en RabbitMQ (Exchange: {Exchange}, RoutingKey: {RoutingKey})",
                @event.Id, _settings.Exchanges.Catalog, _settings.Events.BooksUploaded.RoutingKey);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al publicar BookUploadedEvent en RabbitMQ");
            throw;
        }
    }
}
