using Microsoft.Extensions.Configuration;
using Recommendation.Application.Interfaces;
using Recommendation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recommendation.Application.Services;
public class QdrantService
{

    private readonly IVectorRepository _qdrantVectorRepository;

    public QdrantService(IVectorRepository qdrantVectorRepository)
    {
        _qdrantVectorRepository = qdrantVectorRepository;
    }


    public async Task SaveBooksBatchAsync(IEnumerable<BookVectorRecord> records)
    {
        await _qdrantVectorRepository.SaveBatchAsync(records);
    }

    public async Task SaveBookVectorAsync(BookVectorRecord record)
    {
        await _qdrantVectorRepository.SaveBookVectorAsync(record);
    }

    public async Task SaveStudentVectorAsync(StudentVectorRecord record)
    {
        await _qdrantVectorRepository.SaveStudentVectorAsync(record);
    }

    public async Task<StudentVectorRecord?> GetStudentVectorAsync(long studentId)
    {
        return await _qdrantVectorRepository.GetStudentVectorAsync(studentId);
    }

    public async Task<List<BookVectorRecord>> GetVectorsByBookIdsAsync(IEnumerable<Guid> bookIds)
    {
        return await _qdrantVectorRepository.GetVectorsByBookIdsAsync(bookIds);
    }

    public async Task<List<Guid>> GetTopRecommendationBooksIdsAsync(float[] studentVector, int limit = 5)
    {
        return await _qdrantVectorRepository.GetTopRecommendationBooksIdsAsync(studentVector, limit);
    }
}

