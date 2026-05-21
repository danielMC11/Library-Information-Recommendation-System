using Catalog.Api.Config;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using Recommendation.Application.Events;
using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Catalog.Api.Messaging;

public class CatalogUploadPublisher
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<CatalogUploadPublisher> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public CatalogUploadPublisher(IOptions<RabbitMQSettings> settings, ILogger<CatalogUploadPublisher> logger)
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

    public async Task PublishNewBookBatchAsync(NewBookBatchEvent @event)
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
                exchange: _settings.CalculateEmbeddingExchangeName,
                routingKey: _settings.CalculateEmbeddingRoutingKeyName,
                mandatory: true,
                basicProperties: properties,
                body: body);

            _logger.LogInformation("Lote de {Count} libros publicado en RabbitMQ (Exchange: {Exchange}, RoutingKey: {RoutingKey})",
                @event.Books.Count, _settings.CalculateEmbeddingExchangeName, _settings.CalculateEmbeddingRoutingKeyName);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al publicar NewBookBatchEvent en RabbitMQ");
            throw;
        }
    }
}
