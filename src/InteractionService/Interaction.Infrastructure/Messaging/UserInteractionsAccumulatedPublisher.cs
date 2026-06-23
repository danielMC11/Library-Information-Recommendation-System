using Shared.Config;
using Shared.Events;
using Interaction.Application.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Interaction.Infrastructure.Messaging;

public class UserInteractionsAccumulatedPublisher : IUserInteractionsAccumulatedPublisher
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<UserInteractionsAccumulatedPublisher> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public UserInteractionsAccumulatedPublisher(IOptions<RabbitMQSettings> settings, ILogger<UserInteractionsAccumulatedPublisher> logger)
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

    public async Task PublishAsync(UserInteractionsAccumulatedEvent @event)
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
                exchange: _settings.Exchanges.Interaction,
                routingKey: _settings.Events.UserInteractionsAccumulated.RoutingKey,
                mandatory: true,
                basicProperties: properties,
                body: body);

            _logger.LogInformation("UserInteractionsAccumulated for User {UserId} publicado en RabbitMQ (Exchange: {Exchange}, RoutingKey: {RoutingKey})",
                @event.UserId, _settings.Exchanges.Interaction, _settings.Events.UserInteractionsAccumulated.RoutingKey);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al publicar UserInteractionsAccumulatedEvent en RabbitMQ");
            throw;
        }
    }
}
