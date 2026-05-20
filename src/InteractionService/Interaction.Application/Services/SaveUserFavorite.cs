using Interaction.Application.DTOs;
using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Interaction.Application.Services;

public class SaveUserFavorite
{
    private readonly IUserFavoriteRepository _repository;

    public SaveUserFavorite(IUserFavoriteRepository repository)
    {
        _repository = repository;
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

        return new UserFavoriteDto
        {
            Id = userFavorite.Id,
            UserId = userFavorite.UserId,
            BookId = userFavorite.BookId,
            CreatedAt = userFavorite.CreatedAt
        };
    }
}
