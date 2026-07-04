using Shared.DTOs;
using Recommendation.Application.Interfaces;

namespace Recommendation.Application.Services;

public class BookRecommendationService
{
    private readonly QdrantService _qdrantService;
    private readonly ICatalogApiService _catalogApiService;

    public BookRecommendationService(QdrantService qdrantService, ICatalogApiService catalogApiService)
    {
        _qdrantService = qdrantService;
        _catalogApiService = catalogApiService;
    }

    public async Task<IEnumerable<BookDto>> GetRecommendationsAsync(long studentId, int limit = 10)
    {
        var studentRecord = await _qdrantService.GetStudentVectorAsync(studentId);
        if (studentRecord == null) return Enumerable.Empty<BookDto>();

        var bookIds = await _qdrantService.GetTopRecommendationBooksIdsAsync(studentRecord.Vector, limit);
        if (!bookIds.Any()) return Enumerable.Empty<BookDto>();

        return await _catalogApiService.GetBooksByIdsAsync(bookIds);
    }
}
