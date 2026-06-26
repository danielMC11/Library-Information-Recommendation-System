using Shared.DTOs;
using Catalog.Domain.Entities;

namespace Catalog.Application.Interfaces;


public interface IBookService
{
    Task<BookDto?> GetBookDetailsAsync(Guid id, long studentId);
    Task<List<BookDto>> GetBooksPagedAsync(int page, int pageSize);
    Task<List<BookDto>> SearchBooksAsync(string name, long studentId);
    Task<List<BookDto>> GetBooksByIdsAsync(List<Guid> ids);
}
