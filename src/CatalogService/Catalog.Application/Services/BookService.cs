using Catalog.Application.Interfaces;
using Catalog.Domain.Entities;
using Shared.DTOs;
using Shared.Enums;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Services;
public class BookService : IBookService
{

    private readonly IBookRepository _repository;
    private readonly IInteractionApiService _interactionApi;

    public BookService(IBookRepository repository, IInteractionApiService interactionApi)
    {
        _repository = repository;
        _interactionApi = interactionApi;
    }

    public async Task<BookDto?> GetBookDetailsAsync(Guid id, long studentId)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("El Id del libro no es válido.", nameof(id));

        var book = await _repository.GetBookDetailsAsync(id);

        if (book is null)
            return null;

        await _interactionApi.SendStudentInteractionAsync(new StudentInteractionEvent
        {
            StudentId = studentId,
            Interaction = new StudentInteractionItem
            {
                BookIds = new List<Guid> { book.Id },
                InteractionType = InteractionType.VIEW.ToString()
            }
        });

        return MapToDto(book);
    }

    public async Task<List<BookDto>> GetBooksPagedAsync(int page, int pageSize)
    {
        var books = await _repository.GetBooksPagedAsync(page, pageSize);
        return books.Select(MapToDto).ToList();
    }

    public async Task<List<BookDto>> SearchBooksAsync(string name, long studentId)
    {
        var books = await _repository.SearchBooksAsync(name);

        if (books.Any())
        {
            await _interactionApi.SendStudentInteractionAsync(new StudentInteractionEvent
            {
                StudentId = studentId,
                Interaction = new StudentInteractionItem
                {
                    BookIds = books.Select(b => b.Id).ToList(),
                    InteractionType = InteractionType.SEARCH.ToString()
                }
            });
        }

        return books.Select(MapToDto).ToList();
    }

    public async Task<List<BookDto>> GetBooksByIdsAsync(List<Guid> ids)
    {
        var books = await _repository.GetBooksByIdsAsync(ids);
        return books.Select(MapToDto).ToList();
    }

    private static BookDto MapToDto(Book book)
    {
        return new BookDto
        {
            Id = book.Id,
            Isbn = book.Isbn,
            Title = book.Title,

            Language = book.Language,
            Year = book.Year,
            Summary = book.Summary,
            Authors = book.Authors.Select(a => a.Name),
            Topics = book.Topics.Select(t => t.Name)
        };
    }



}
