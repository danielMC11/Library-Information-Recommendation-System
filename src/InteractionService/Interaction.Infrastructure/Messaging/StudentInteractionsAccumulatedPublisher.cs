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

public class StudentInteractionsAccumulatedPublisher : IStudentInteractionsAccumulatedPublisher
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<StudentInteractionsAccumulatedPublisher> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public StudentInteractionsAccumulatedPublisher(IOptions<RabbitMQSettings> settings, ILogger<StudentInteractionsAccumulatedPublisher> logger)
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

    public async Task PublishAsync(StudentInteractionsAccumulatedEvent @event)
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
                routingKey: _settings.Events.StudentInteractionsAccumulated.RoutingKey,
                mandatory: true,
                basicProperties: properties,
                body: body);

            _logger.LogInformation("StudentInteractionsAccumulated for User {UserId} publicado en RabbitMQ (Exchange: {Exchange}, RoutingKey: {RoutingKey})",
                @event.StudentId, _settings.Exchanges.Interaction, _settings.Events.StudentInteractionsAccumulated.RoutingKey);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al publicar StudentInteractionsAccumulatedEvent en RabbitMQ");
            throw;
        }
    }
}
