using Shared.DTOs;

namespace Interaction.Application.Interfaces;

public interface ICatalogApiService
{
    Task<IEnumerable<BookDto>> GetBooksByIdsAsync(List<Guid> ids);
}
