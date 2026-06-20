namespace Catalog.Application.Interfaces;

public interface IBookService
{
    Task<BookDetailsDto?> GetBookDetailsAsync(Guid id);
    Task<List<BookDetailsDto>> GetBooksPagedAsync(int page, int pageSize);
    Task<List<BookDetailsDto>> SearchBooksAsync(string name);
    Task<List<BookDetailsDto>> GetBooksByIdsAsync(List<Guid> ids);
}
