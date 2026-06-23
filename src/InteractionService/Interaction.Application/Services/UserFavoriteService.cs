using Shared.DTOs;
using Shared.Events;
using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interaction.Application.Services;

public class UserFavoriteService
{
    private readonly IUserFavoriteRepository _repository;
    private readonly UserInteractionService _userInteractionService;
    private readonly ICatalogApiService _catalogApiService;

    public UserFavoriteService(IUserFavoriteRepository repository, UserInteractionService userInteractionService, ICatalogApiService catalogApiService)
    {
        _repository = repository;
        _userInteractionService = userInteractionService;
        _catalogApiService = catalogApiService;
    }

    public async Task<bool> CheckFavoriteAsync(Guid userId, Guid bookId)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));

        if (bookId == Guid.Empty)
            throw new ArgumentException("BookId cannot be empty.", nameof(bookId));

        return await _repository.CheckUserFavoriteBookAsync(userId, bookId);
    }

    public async Task<IEnumerable<BookDto>> GetUserFavoritesAsync(Guid userId)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));

        var favorites = await _repository.GetUserFavoriteBooksAsync(userId);

        var bookIds = favorites?.Select(f => f.BookId).Where(id => id != Guid.Empty).ToList() ?? new List<Guid>();

        if (bookIds.Count == 0)
            return new List<BookDto>();

        return await _catalogApiService.GetBooksByIdsAsync(bookIds);
    }

    public async Task<UserFavoriteDto> SaveFavoriteAsync(Guid userId, Guid bookId)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));

        if (bookId == Guid.Empty)
            throw new ArgumentException("BookId cannot be empty.", nameof(bookId));

        var isAlreadyFavorite = await _repository.CheckUserFavoriteBookAsync(userId, bookId);
        if (isAlreadyFavorite)
        {
            var favorites = await _repository.GetUserFavoriteBooksAsync(userId);
            var existing = favorites.FirstOrDefault(f => f.BookId == bookId);
            if (existing != null)
            {
                return new UserFavoriteDto
                {
                    Id = existing.Id,
                    UserId = existing.UserId,
                    BookId = existing.BookId,
                    CreatedAt = existing.CreatedAt
                };
            }
        }

        var userFavorite = new UserFavorite
        {
            UserId = userId,
            BookId = bookId,
            CreatedAt = DateTime.UtcNow
        };

        await _repository.SaveUserFavoriteBookAsync(userFavorite);

        await _userInteractionService.ExecuteAsync(new UserInteractionEvent
        {
            UserId = userId,
            BookIds = new List<Guid> { bookId },
            InteractionType = "FAVORITE"
        });

        return new UserFavoriteDto
        {
            Id = userFavorite.Id,
            UserId = userFavorite.UserId,
            BookId = userFavorite.BookId,
            CreatedAt = userFavorite.CreatedAt
        };
    }

    public async Task DeleteFavoriteAsync(Guid userId, Guid bookId)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));

        if (bookId == Guid.Empty)
            throw new ArgumentException("BookId cannot be empty.", nameof(bookId));

        var isFavorite = await _repository.CheckUserFavoriteBookAsync(userId, bookId);
        if (!isFavorite)
            throw new InvalidOperationException($"Book {bookId} is not a favorite of user {userId}.");

        await _repository.DeleteUserFavoriteBookAsync(userId, bookId);

        await _userInteractionService.ExecuteAsync(new UserInteractionEvent
        {
            UserId = userId,
            BookIds = new List<Guid> { bookId },
            InteractionType = "UNFAVORITE"
        });
    }
}
