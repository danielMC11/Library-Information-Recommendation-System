using Interaction.Application.DTOs;
using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using Interaction.Domain.enums;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Interaction.Application.Services;

public class SaveUserFavorite
{
    private readonly IUserFavoriteRepository _repository;
    private readonly SaveUserInteraction _saveUserInteraction;

    public SaveUserFavorite(IUserFavoriteRepository repository, SaveUserInteraction saveUserInteraction)
    {
        _repository = repository;
        _saveUserInteraction = saveUserInteraction;
    }

    public async Task<UserFavoriteDto> ExecuteAsync(Guid userId, Guid bookId)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));

        if (bookId == Guid.Empty)
            throw new ArgumentException("BookId cannot be empty.", nameof(bookId));

        // Check if already favorited to avoid duplicate key exceptions
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

        await _saveUserInteraction.ExecuteAsync(new Events.UserInteractionEvent {
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
}
