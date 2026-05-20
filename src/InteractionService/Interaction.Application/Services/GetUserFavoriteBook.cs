using Interaction.Application.DTOs;
using Interaction.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interaction.Application.Services;

public class GetUserFavoriteBook
{
    private readonly IUserFavoriteRepository _repository;

    public GetUserFavoriteBook(IUserFavoriteRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<UserFavoriteDto>> ExecuteAsync(Guid userId)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));

        var favorites = await _repository.GetUserFavoriteBooksAsync(userId);

        return favorites.Select(f => new UserFavoriteDto
        {
            Id = f.Id,
            UserId = f.UserId,
            BookId = f.BookId,
            CreatedAt = f.CreatedAt
        });
    }
}
