using Recommendation.Domain.Entities;

namespace Recommendation.Application.Interfaces;

public interface IQdrantService
{
    Task SaveBooksBatchAsync(IEnumerable<BookVectorRecord> records);
    Task SaveBookVectorAsync(BookVectorRecord record);
    Task SaveStudentVectorAsync(StudentVectorRecord record);
    Task<StudentVectorRecord?> GetStudentVectorAsync(long studentId);
    Task<List<BookVectorRecord>> GetVectorsByBookIdsAsync(IEnumerable<Guid> bookIds);
    Task<List<Guid>> GetTopRecommendationBooksIdsAsync(float[] studentVector, int limit = 5);
}
