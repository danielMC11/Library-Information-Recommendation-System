using Catalog.Application.Interfaces;
using Catalog.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Services;
public class BookService : IBookService
{

    private readonly IBookRepository _repository;

    public BookService(IBookRepository repository)
    {
        _repository = repository;
    }

    public async Task<BookDetailsDto?> GetBookDetailsAsync(Guid id)
    {


        if (id == Guid.Empty)
            throw new ArgumentException("El Id del libro no es válido.", nameof(id));

        var book = await _repository.GetBookDetailsAsync(id);

        if (book is null)
            return null;

        return MapToDto(book);
    }

    public async Task<List<BookDetailsDto>> GetBooksPagedAsync(int page, int pageSize)
    {
        var books = await _repository.GetBooksPagedAsync(page, pageSize);
        return books.Select(MapToDto).ToList();
    }

    public async Task<List<BookDetailsDto>> SearchBooksAsync(string name)
    {
        var books = await _repository.SearchBooksAsync(name);
        return books.Select(MapToDto).ToList();
    }

    public async Task<List<BookDetailsDto>> GetBooksByIdsAsync(List<Guid> ids)
    {
        var books = await _repository.GetBooksByIdsAsync(ids);
        return books.Select(MapToDto).ToList();
    }

    private static BookDetailsDto MapToDto(Book book)
    {
        return new BookDetailsDto
        {
            Id = book.Id,
            Isbn = book.Isbn,
            Title = book.Title,
            Classification = book.Classification,
            Language = book.Language,
            Year = book.Year,
            Summary = book.Summary,
            Authors = book.Authors.Select(a => a.Name),
            Topics = book.Topics.Select(t => t.Name)
        };
    }

}
