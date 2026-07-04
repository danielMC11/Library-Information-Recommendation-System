using Shared.Config;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using Shared.Events;
using System.Text;
using System.Text.Json;
using MiniIdentityApi.Application.Interfaces;

namespace MiniIdentityApi.Infrastructure.Messaging;

public class StudentRegisteredPublisher : IStudentRegisteredPublisher
{
    private readonly RabbitMQSettings _settings;
    private readonly ILogger<StudentRegisteredPublisher> _logger;
    private IConnection? _connection;
    private IChannel? _channel;

    public StudentRegisteredPublisher(IOptions<RabbitMQSettings> settings, ILogger<StudentRegisteredPublisher> logger)
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

    public async Task PublishAsync(StudentRegisteredEvent @event)
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
                exchange: _settings.Exchanges.Auth,
                routingKey: _settings.Events.StudentRegistered.RoutingKey,
                mandatory: true,
                basicProperties: properties,
                body: body);

            _logger.LogInformation("Evento StudentRegistered publicado en RabbitMQ (Exchange: {Exchange}, RoutingKey: {RoutingKey}, StudentId: {StudentId})",
                _settings.Exchanges.Auth, _settings.Events.StudentRegistered.RoutingKey, @event.StudentId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al publicar StudentRegisteredEvent en RabbitMQ");
            throw;
        }
    }
}
