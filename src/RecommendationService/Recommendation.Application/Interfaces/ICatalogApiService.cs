using Shared.DTOs;

namespace Recommendation.Application.Interfaces;

public interface ICatalogApiService
{
    Task<IEnumerable<BookDto>> GetBooksByIdsAsync(List<Guid> ids);
}
