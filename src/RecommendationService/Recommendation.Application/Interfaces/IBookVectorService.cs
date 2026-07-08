using Shared.Events;

namespace Recommendation.Application.Interfaces;

public interface IBookVectorService
{
    Task ProcessEmbeddingAsync(BookUploadedEvent @event);
}
