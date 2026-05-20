using Interaction.Application.DTOs;
using Interaction.Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Interaction.Application.Services;

public class CheckFavoriteBooksAsync
{
    private readonly IUserFavoriteRepository _repository;

    public CheckFavoriteBooksAsync(IUserFavoriteRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> ExecuteAsync(Guid userId, Guid bookId)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));

        if (bookId == Guid.Empty)
            throw new ArgumentException("BookId cannot be empty.", nameof(bookId));

        return await _repository.CheckUserFavoriteBookAsync(userId, bookId);
    }
}
