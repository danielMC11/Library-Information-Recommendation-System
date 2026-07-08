using Shared.DTOs;

namespace Recommendation.Application.Interfaces;

public interface IBookRecommendationService
{
    Task<IEnumerable<BookDto>> GetRecommendationsAsync(long studentId, int limit = 10);
}
