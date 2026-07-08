using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using Shared.Config;
using Shared.Helpers;
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
        await RetryHelper.RetryOnExceptionAsync(async ct =>
        {
            var factory = new ConnectionFactory
            {
                HostName = _settings.HostName,
                Port = _settings.Port,
                UserName = _settings.UserName,
                Password = _settings.Password,
                VirtualHost = _settings.VirtualHost
            };

            _connection = await factory.CreateConnectionAsync(ct);
            _channel = await _connection.CreateChannelAsync(cancellationToken: ct);

            await _channel.ExchangeDeclareAsync(
                exchange: _settings.Exchanges.Catalog,
                type: ExchangeType.Direct,
                durable: true,
                autoDelete: false,
                arguments: null,
                cancellationToken: ct);

            _logger.LogInformation("Catalog exchange '{Exchange}' declared successfully", _settings.Exchanges.Catalog);
        }, _logger, "RabbitMQ Catalog exchange", cancellationToken);
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        if (_channel != null) await _channel.CloseAsync(cancellationToken: cancellationToken);
        if (_connection != null) await _connection.CloseAsync(cancellationToken: cancellationToken);
    }
}
