using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using Shared.Config;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Messaging.Config;

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

            await _channel.ExchangeDeclareAsync(
                exchange: _settings.Exchanges.Catalog,
                type: ExchangeType.Topic,
                durable: true,
                autoDelete: false,
                arguments: null,
                cancellationToken: cancellationToken);

            _logger.LogInformation("Catalog exchange '{Exchange}' declared successfully", _settings.Exchanges.Catalog);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to initialize RabbitMQ catalog exchange.");
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        if (_channel != null) await _channel.CloseAsync(cancellationToken: cancellationToken);
        if (_connection != null) await _connection.CloseAsync(cancellationToken: cancellationToken);
    }
}
