using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using Shared.Config;
using Shared.Helpers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Recommendation.Infrastructure.Messaging.Config;

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

            await _channel.ExchangeDeclareAsync(
                exchange: _settings.Exchanges.Interaction,
                type: ExchangeType.Direct,
                durable: true,
                autoDelete: false,
                arguments: null,
                cancellationToken: ct);

            _logger.LogInformation("Interaction exchange '{Exchange}' declared successfully", _settings.Exchanges.Interaction);

            await _channel.ExchangeDeclareAsync(
                exchange: _settings.Exchanges.Auth,
                type: ExchangeType.Direct,
                durable: true,
                autoDelete: false,
                arguments: null,
                cancellationToken: ct);

            _logger.LogInformation("Auth exchange '{Exchange}' declared successfully", _settings.Exchanges.Auth);

            // StudentRegistered queue bind to auth exchange
            await _channel.QueueDeclareAsync(
                queue: _settings.Events.StudentRegistered.Queue,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null,
                cancellationToken: ct);

            await _channel.QueueBindAsync(
                queue: _settings.Events.StudentRegistered.Queue,
                exchange: _settings.Exchanges.Auth,
                routingKey: _settings.Events.StudentRegistered.RoutingKey,
                arguments: null,
                cancellationToken: ct);

            _logger.LogInformation("StudentRegistered queue '{Queue}' bound to exchange '{Exchange}' with routing key '{RoutingKey}'",
                _settings.Events.StudentRegistered.Queue, _settings.Exchanges.Auth, _settings.Events.StudentRegistered.RoutingKey);

            // BooksUploaded queue bind to catalog exchange
            await _channel.QueueDeclareAsync(
                queue: _settings.Events.BooksUploaded.Queue,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null,
                cancellationToken: ct);

            await _channel.QueueBindAsync(
                queue: _settings.Events.BooksUploaded.Queue,
                exchange: _settings.Exchanges.Catalog,
                routingKey: _settings.Events.BooksUploaded.RoutingKey,
                arguments: null,
                cancellationToken: ct);

            _logger.LogInformation("BooksUploaded queue '{Queue}' bound to exchange '{Exchange}' with routing key '{RoutingKey}'",
                _settings.Events.BooksUploaded.Queue, _settings.Exchanges.Catalog, _settings.Events.BooksUploaded.RoutingKey);

            // StudentInteractionsAccumulated queue bind to interaction exchange
            await _channel.QueueDeclareAsync(
                queue: _settings.Events.StudentInteractionsAccumulated.Queue,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null,
                cancellationToken: ct);

            await _channel.QueueBindAsync(
                queue: _settings.Events.StudentInteractionsAccumulated.Queue,
                exchange: _settings.Exchanges.Interaction,
                routingKey: _settings.Events.StudentInteractionsAccumulated.RoutingKey,
                arguments: null,
                cancellationToken: ct);

            _logger.LogInformation("StudentInteractionsAccumulated queue '{Queue}' bound to exchange '{Exchange}' with routing key '{RoutingKey}'",
                _settings.Events.StudentInteractionsAccumulated.Queue, _settings.Exchanges.Interaction, _settings.Events.StudentInteractionsAccumulated.RoutingKey);
        }, _logger, "RabbitMQ exchanges and queues", cancellationToken);
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        if (_channel != null) await _channel.CloseAsync(cancellationToken: cancellationToken);
        if (_connection != null) await _connection.CloseAsync(cancellationToken: cancellationToken);
    }
}
