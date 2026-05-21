using Microsoft.Extensions.Configuration;
using Recommendation.Application.Events;
using Recommendation.Application.Interfaces;
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


    public async Task SaveBatchAsync(IEnumerable<Recommendation.Domain.Entities.BookVectorRecord> records)
    {
        await _qdrantVectorRepository.SaveBatchAsync(records);
    }
}

