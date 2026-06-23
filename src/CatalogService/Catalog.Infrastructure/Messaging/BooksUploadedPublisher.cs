using Shared.Config;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using Shared.Events;
using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Catalog.Application.Interfaces;

namespace Catalog.Infrastructure.Messaging;

public class BooksUploadedPublisher : IBooksUploadedPublisher
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<BooksUploadedPublisher> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public BooksUploadedPublisher(IOptions<RabbitMQSettings> settings, ILogger<BooksUploadedPublisher> logger)
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

    public async Task PublishAsync(BooksUploadedEvent @event)
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

            _logger.LogInformation("Lote de {Count} libros publicado en RabbitMQ (Exchange: {Exchange}, RoutingKey: {RoutingKey})",
                @event.Books.Count, _settings.Exchanges.Catalog, _settings.Events.BooksUploaded.RoutingKey);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al publicar NewBookBatchEvent en RabbitMQ");
            throw;
        }
    }
}
