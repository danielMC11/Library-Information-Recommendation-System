using Interaction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interaction.Application.Interfaces;


public interface IUserFavoriteRepository
{

    Task SaveUserFavoriteBookAsync(UserFavorite userFavorite);
    Task DeleteUserFavoriteBookAsync(Guid userId, Guid bookId);
    Task<IEnumerable<UserFavorite>> GetUserFavoriteBooksAsync(Guid userId);
    Task<bool> CheckUserFavoriteBookAsync(Guid userId, Guid bookId);

}

