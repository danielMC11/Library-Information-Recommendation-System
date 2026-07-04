namespace Shared.Config;
public class RabbitMQSettings
{
    public const string SectionName = "RabbitMQ";

    public string HostName { get; set; } = string.Empty;
    public int Port { get; set; } = 5672;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string VirtualHost { get; set; } = "/";

    // Ahora mapea a tu nueva clase fuertemente tipada
    public RabbitMQExchanges Exchanges { get; set; } = new();
    public RabbitMQEvents Events { get; set; } = new();

}