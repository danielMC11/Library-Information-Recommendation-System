using System;
using System.Collections.Generic;
using System.Text;



namespace Catalog.Application.Interfaces;

using Catalog.Domain.Entities;



public interface IBookRepository
{
    Task<List<Book>> SaveAllAsync(IEnumerable<Book> books);
    Task<List<Book>> GetExistingBooksWithAuthorsAsync();
    Task<IEnumerable<Author>> GetAllAuthorsAsync();
    Task<IEnumerable<Topic>> GetAllTopicsAsync();

    Task<Book?> GetBookDetailsAsync(Guid bookId);

    Task<List<Book>> GetBooksPagedAsync(int page, int pageSize);

    Task<List<Book>> SearchBooksAsync(string name);

    Task<List<Book>> GetBooksByIdsAsync(List<Guid> ids);
}
