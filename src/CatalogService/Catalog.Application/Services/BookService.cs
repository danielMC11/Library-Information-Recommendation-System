using Catalog.Application.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Services;
public class BookService
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

