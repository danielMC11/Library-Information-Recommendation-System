using System;
using System.Collections.Generic;
using System.Text;



namespace Catalog.Application.Interfaces;

using Catalog.Domain.Entities;



public interface IBookRepository
{
    Task SaveAllAsync(IEnumerable<Book> books);
    Task<List<Book>> GetExistingBooksWithAuthorsAsync();
    Task<IEnumerable<Author>> GetAllAuthorsAsync();
    Task<IEnumerable<Topic>> GetAllTopicsAsync();

}
