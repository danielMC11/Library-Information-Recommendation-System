using Catalog.Api.Config;
using Interaction.Application.Events;
using Interaction.Application.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Interaction.Api.Messaging;

public class UserProfilePublisher : IUserProfilePublisher
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<UserProfilePublisher> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public UserProfilePublisher(IOptions<RabbitMQSettings> settings, ILogger<UserProfilePublisher> logger)
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

    public async Task PublishUserProfileCalculationEventAsync(UserProfileCalculationEvent @event)
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
                routingKey: _settings.UserEventRecommendationRoutingKeyName,
                mandatory: true,
                basicProperties: properties,
                body: body);

            _logger.LogInformation("UserProfileCalculationEvent for User {UserId} publicado en RabbitMQ (Exchange: {Exchange}, RoutingKey: {RoutingKey})",
                @event.UserId, _settings.UserEventExchangeName, _settings.UserEventRecommendationRoutingKeyName);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al publicar UserProfileCalculationEvent en RabbitMQ");
            throw;
        }
    }
}
