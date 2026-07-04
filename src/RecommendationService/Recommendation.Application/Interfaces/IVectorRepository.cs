using Recommendation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recommendation.Application.Interfaces;


public interface IVectorRepository
{
    Task SaveBatchAsync(IEnumerable<BookVectorRecord> records);
    Task SaveBookVectorAsync(BookVectorRecord record);
    Task<List<BookVectorRecord>> GetVectorsByBookIdsAsync(IEnumerable<Guid> bookIds);

    Task SaveStudentVectorAsync(StudentVectorRecord record);
    Task<StudentVectorRecord?> GetStudentVectorAsync(long studentId);

    Task<List<Guid>> GetTopRecommendationBooksIdsAsync(float[] studentVector, int limit = 5);
}
