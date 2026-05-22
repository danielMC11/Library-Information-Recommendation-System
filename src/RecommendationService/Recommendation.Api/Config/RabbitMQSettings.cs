namespace Recommendation.Api.Config;
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

    public string CalculateEmbeddingQueueName { get; set; } = "";

    public string UserEventExchangeName { get; set; } = "";
    public string UserEventInteractionRoutingKeyName { get; set; } = "";
    public string UserEventInteractionQueueName { get; set; } = "";

    public string UserEventRecommendationRoutingKeyName { get; set; } = "";

    public string UserEventRecommendationQueueName { get; set; } = "";

}