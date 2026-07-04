using Shared.Events;
using Microsoft.Extensions.Logging;
using Recommendation.Domain.Entities;

namespace Recommendation.Application.Services;

public class BookVectorService
{
    private readonly GeminiEmbeddingService _geminiEmbeddingService;
    private readonly QdrantService _qdrantService;
    private readonly ILogger<BookVectorService> _logger;

    public BookVectorService(GeminiEmbeddingService geminiEmbeddingService, QdrantService qdrantService, ILogger<BookVectorService> logger)
    {
        _geminiEmbeddingService = geminiEmbeddingService;
        _qdrantService = qdrantService;
        _logger = logger;
    }

    public async Task ProcessEmbeddingAsync(BookUploadedEvent @event)
    {
        _logger.LogInformation("Processing embedding for book {BookId}: {Description}",
            @event.Id, @event.Description?.Length > 80 ? @event.Description[..80] + "..." : @event.Description);

        try
        {
            var existing = await _qdrantService.GetVectorsByBookIdsAsync([@event.Id]);
            if (existing.Count > 0)
            {
                _logger.LogInformation("Vector already exists in Qdrant for book {BookId}, skipping", @event.Id);
                return;
            }

            var vector = await _geminiEmbeddingService.GenerateEmbeddingAsync(@event.Description ?? "");

            var metadata = new Dictionary<string, string>
            {
                { "bookId", @event.Id.ToString() },
                { "isbn", @event.Isbn ?? "" },
                { "year", @event.Year ?? "" },
                { "language", @event.Language ?? "" }
            };

            var record = new BookVectorRecord(@event.Id, vector, metadata);
            await _qdrantService.SaveBookVectorAsync(record);

            _logger.LogInformation("Embedding saved to Qdrant for book {BookId}", @event.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error generating embedding for book {BookId}", @event.Id);
            throw;
        }
    }
}
