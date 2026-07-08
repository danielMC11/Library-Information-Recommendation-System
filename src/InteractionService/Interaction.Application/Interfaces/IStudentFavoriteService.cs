using Shared.DTOs;

namespace Interaction.Application.Interfaces;

public interface IStudentFavoriteService
{
    Task<bool> CheckFavoriteAsync(long studentId, Guid bookId);
    Task<IEnumerable<BookDto>> GetStudentFavoritesAsync(long studentId);
    Task<StudentFavoriteDto> SaveFavoriteAsync(long studentId, Guid bookId);
    Task DeleteFavoriteAsync(long studentId, Guid bookId);
}
