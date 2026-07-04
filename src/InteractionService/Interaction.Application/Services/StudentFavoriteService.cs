using Shared.DTOs;
using Shared.Events;
using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;

namespace Interaction.Application.Services;

public class StudentFavoriteService
{
    private readonly IStudentFavoriteRepository _repository;
    private readonly StudentInteractionService _studentInteractionService;
    private readonly ICatalogApiService _catalogApiService;

    public StudentFavoriteService(IStudentFavoriteRepository repository, StudentInteractionService studentInteractionService, ICatalogApiService catalogApiService)
    {
        _repository = repository;
        _studentInteractionService = studentInteractionService;
        _catalogApiService = catalogApiService;
    }

    public async Task<bool> CheckFavoriteAsync(long studentId, Guid bookId)
    {
        if (bookId == Guid.Empty)
            throw new ArgumentException("BookId cannot be empty.", nameof(bookId));

        return await _repository.CheckStudentFavoriteBookAsync(studentId, bookId);
    }

    public async Task<IEnumerable<BookDto>> GetStudentFavoritesAsync(long studentId)
    {
        var favorites = await _repository.GetStudentFavoriteBooksAsync(studentId);

        var bookIds = favorites?.Select(f => f.BookId).Where(id => id != Guid.Empty).ToList() ?? new List<Guid>();

        if (bookIds.Count == 0)
            return new List<BookDto>();

        return await _catalogApiService.GetBooksByIdsAsync(bookIds);
    }

    public async Task<StudentFavoriteDto> SaveFavoriteAsync(long studentId, Guid bookId)
    {
        if (bookId == Guid.Empty)
            throw new ArgumentException("BookId cannot be empty.", nameof(bookId));

        var isAlreadyFavorite = await _repository.CheckStudentFavoriteBookAsync(studentId, bookId);
        if (isAlreadyFavorite)
        {
            var favorites = await _repository.GetStudentFavoriteBooksAsync(studentId);
            var existing = favorites.FirstOrDefault(f => f.BookId == bookId);
            if (existing != null)
            {
                return new StudentFavoriteDto
                {
                    Id = existing.Id,
                    StudentId = existing.StudentId,
                    BookId = existing.BookId,
                    CreatedAt = existing.CreatedAt
                };
            }
        }

        var studentFavorite = new StudentFavorite
        {
            StudentId = studentId,
            BookId = bookId,
            CreatedAt = DateTime.UtcNow
        };

        await _repository.SaveStudentFavoriteBookAsync(studentFavorite);

        await _studentInteractionService.ExecuteAsync(new StudentInteractionEvent
        {
            StudentId = studentId,
            Interaction = new StudentInteractionItem
            {
                BookIds = new List<Guid> { bookId },
                InteractionType = "FAVORITE"
            }
        });

        return new StudentFavoriteDto
        {
            Id = studentFavorite.Id,
            StudentId = studentFavorite.StudentId,
            BookId = studentFavorite.BookId,
            CreatedAt = studentFavorite.CreatedAt
        };
    }

    public async Task DeleteFavoriteAsync(long studentId, Guid bookId)
    {
        if (bookId == Guid.Empty)
            throw new ArgumentException("BookId cannot be empty.", nameof(bookId));

        var isFavorite = await _repository.CheckStudentFavoriteBookAsync(studentId, bookId);
        if (!isFavorite)
            throw new InvalidOperationException($"Book {bookId} is not a favorite of student {studentId}.");

        await _repository.DeleteStudentFavoriteBookAsync(studentId, bookId);

        await _studentInteractionService.ExecuteAsync(new StudentInteractionEvent
        {
            StudentId = studentId,
            Interaction = new StudentInteractionItem
            {
                BookIds = new List<Guid> { bookId },
                InteractionType = "UNFAVORITE"
            }
        });
    }
}