namespace Catalog.Api.Config;
public class RabbitMQSettings
{
    public const string SectionName = "RabbitMQ";

    public string HostName { get; set; } = "localhost";
    public int Port { get; set; } = 5672;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string VirtualHost { get; set; } = "/";

    public string CalculateEmbeddingExchangeName { get; set; } = "";

    public string CalculateEmbeddingRoutingKeyName { get; set; } = "";

}