using Interaction.Domain.Entities;

namespace Interaction.Application.Interfaces;

public interface IStudentFavoriteRepository
{
    Task SaveStudentFavoriteBookAsync(StudentFavorite studentFavorite);
    Task DeleteStudentFavoriteBookAsync(long studentId, Guid bookId);
    Task<IEnumerable<StudentFavorite>> GetStudentFavoriteBooksAsync(long studentId);
    Task<bool> CheckStudentFavoriteBookAsync(long studentId, Guid bookId);
}