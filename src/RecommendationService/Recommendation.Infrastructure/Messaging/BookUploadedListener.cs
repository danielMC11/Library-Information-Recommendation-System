using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Shared.Config;
using Shared.Events;
using Recommendation.Application.Interfaces;

namespace Recommendation.Infrastructure.Messaging;

public class BookUploadedListener : RateLimitedRabbitListenerBase<BookUploadedEvent>
{
    public BookUploadedListener(
        IOptions<RabbitMQSettings> settings,
        ILogger<BookUploadedListener> logger,
        IServiceScopeFactory scopeFactory)
        : base(settings, logger, scopeFactory) { }

    protected override string QueueName => _settings.Events.BooksUploaded.Queue;
    protected override string ResumeConfigKey => "GeminiResumeAtUtc";
    protected override int EstimateTokens(BookUploadedEvent @event) => @event.Description?.Length / 4 ?? 0;

    protected override async Task ProcessMessageAsync(BookUploadedEvent @event, IServiceScope scope)
    {
        var bookVectorService = scope.ServiceProvider.GetRequiredService<IBookVectorService>();
        await bookVectorService.ProcessEmbeddingAsync(@event);
    }
}
