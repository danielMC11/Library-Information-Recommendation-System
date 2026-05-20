
using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using Interaction.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace Interaction.Infrastructure.Repositories;

public class UserFavoriteRepository : IUserFavoriteRepository
{
    private readonly AppDbContext _context;

    public UserFavoriteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task SaveUserFavoriteBookAsync(UserFavorite userFavorite)
    {
        await _context.UserFavorites.AddAsync(userFavorite);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<UserFavorite>> GetUserFavoriteBooksAsync(Guid userId)
    {
        return await _context.UserFavorites
            .Where(uf => uf.UserId == userId)
            .OrderByDescending(uf => uf.CreatedAt)
            .ToListAsync();
    }

    public async Task<bool> CheckUserFavoriteBookAsync(Guid userId, Guid bookId)
    {
        return await _context.UserFavorites
            .AnyAsync(uf => uf.UserId == userId && uf.BookId == bookId);
    }
}

