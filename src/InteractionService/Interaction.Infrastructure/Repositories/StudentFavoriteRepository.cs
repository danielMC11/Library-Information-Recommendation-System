using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using Interaction.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Interaction.Infrastructure.Repositories;

public class StudentFavoriteRepository : IStudentFavoriteRepository
{
    private readonly AppDbContext _context;

    public StudentFavoriteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task SaveStudentFavoriteBookAsync(StudentFavorite studentFavorite)
    {
        await _context.StudentFavorites.AddAsync(studentFavorite);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<StudentFavorite>> GetStudentFavoriteBooksAsync(long studentId)
    {
        return await _context.StudentFavorites
            .Where(sf => sf.StudentId == studentId)
            .OrderByDescending(sf => sf.CreatedAt)
            .ToListAsync();
    }

    public async Task<bool> CheckStudentFavoriteBookAsync(long studentId, Guid bookId)
    {
        return await _context.StudentFavorites
            .AnyAsync(sf => sf.StudentId == studentId && sf.BookId == bookId);
    }

    public async Task DeleteStudentFavoriteBookAsync(long studentId, Guid bookId)
    {
        var favorite = await _context.StudentFavorites
            .FirstOrDefaultAsync(sf => sf.StudentId == studentId && sf.BookId == bookId);

        if (favorite != null)
        {
            _context.StudentFavorites.Remove(favorite);
            await _context.SaveChangesAsync();
        }
    }
}