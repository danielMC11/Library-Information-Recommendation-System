using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Recommendation.Api.Config;

public class RabbitMQConfig : IHostedService
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<RabbitMQConfig> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public RabbitMQConfig(IOptions<RabbitMQSettings> settings, ILogger<RabbitMQConfig> logger)
    {
        _settings = settings.Value;
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        try
        {
            var factory = new ConnectionFactory
            {
                HostName = _settings.HostName,
                Port = _settings.Port,
                UserName = _settings.UserName,
                Password = _settings.Password,
                VirtualHost = _settings.VirtualHost
            };

            _connection = await factory.CreateConnectionAsync(cancellationToken);
            _channel = await _connection.CreateChannelAsync(cancellationToken: cancellationToken);

            // Declarar Exchange
            await _channel.ExchangeDeclareAsync(
                exchange: _settings.CalculateEmbeddingExchangeName,
                type: ExchangeType.Topic,
                durable: true,
                autoDelete: false,
                arguments: null,
                cancellationToken: cancellationToken);

            // Declarar Queue
            await _channel.QueueDeclareAsync(
                queue: _settings.CalculateEmbeddingQueueName,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null,
                cancellationToken: cancellationToken);

            // Configurar Binding (Queue <-> Exchange por medio del Routing Key)
            await _channel.QueueBindAsync(
                queue: _settings.CalculateEmbeddingQueueName,
                exchange: _settings.CalculateEmbeddingExchangeName,
                routingKey: _settings.CalculateEmbeddingRoutingKeyName,
                arguments: null,
                cancellationToken: cancellationToken);

            _logger.LogInformation("RabbitMQ setup completed: Exchange {Exchange}, Queue {Queue}, RoutingKey {RoutingKey}", 
                _settings.CalculateEmbeddingExchangeName, _settings.CalculateEmbeddingQueueName, _settings.CalculateEmbeddingRoutingKeyName);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to initialize RabbitMQ exchange and queue.");
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        if (_channel != null) await _channel.CloseAsync(cancellationToken: cancellationToken);
        if (_connection != null) await _connection.CloseAsync(cancellationToken: cancellationToken);
    }
}
