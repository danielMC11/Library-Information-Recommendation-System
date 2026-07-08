using Microsoft.Extensions.Configuration;
using Qdrant.Client;
using Qdrant.Client.Grpc;
using Recommendation.Application.Interfaces;
using Recommendation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;



namespace Recommendation.Infrastructure.Repositories;
public class QdrantVectorRepository : IVectorRepository
{

    private readonly QdrantClient _qdrantClient;
    private const string CollectionName = "books_collection";
    private const string StudentCollectionName = "student_profiles";

    public QdrantVectorRepository(IConfiguration config)
    {
        // Se conecta a Qdrant (por defecto localhost:6334 usando gRPC)
        _qdrantClient = new QdrantClient(new Uri(config["Qdrant:Url"]));
    }

    public async Task SaveBatchAsync(IEnumerable<BookVectorRecord> records)
    {
        // 1. Asegurar que la colección existe (idealmente hacer esto una sola vez al iniciar la app)
        if (!await _qdrantClient.CollectionExistsAsync(CollectionName))
        {
            await _qdrantClient.CreateCollectionAsync(CollectionName,
                new VectorParams { Size = 768, Distance = Distance.Cosine });
        }

        // 2. Convertir nuestros registros al formato PointStruct de Qdrant
        var points = records.Select(record => {
            var point = new PointStruct
            {
                Id = record.Id,
                Vectors = record.Vector
            };

            // Agregamos los metadatos al Payload
            foreach (var meta in record.Metadata)
            {
                point.Payload.Add(meta.Key, meta.Value);
            }

            return point;
        }).ToList();

        // 3. Inserción masiva ultra eficiente
        await _qdrantClient.UpsertAsync(CollectionName, points);
    }

    public async Task SaveBookVectorAsync(BookVectorRecord record)
    {
        await SaveBatchAsync(new[] { record });
    }

    public async Task<List<BookVectorRecord>> GetVectorsByBookIdsAsync(IEnumerable<Guid> bookIds)
    {
        if (!await _qdrantClient.CollectionExistsAsync(CollectionName))
            return [];

        var pointIds = bookIds.Select(id => (PointId)id).ToList();
        
        var points = await _qdrantClient.RetrieveAsync(
            collectionName: CollectionName,
            ids: pointIds,
            withVectors: true,
            withPayload: true
        );

        var records = new List<BookVectorRecord>();
        foreach (var point in points)
        {
            var id = point.Id.Uuid; // or parsing from whatever format
            // In Qdrant .NET Client, point.Id.HasUuid might be true.
            Guid guidId = Guid.Parse(point.Id.Uuid);

            var vectorData = point.Vectors.Vector.Dense.Data;

            if (vectorData == null || vectorData.Count == 0)
                continue;

            var vector = vectorData.ToArray();

            // Get payload
            var metadata = new Dictionary<string, string>();
            foreach (var p in point.Payload)
            {
                metadata[p.Key] = p.Value.StringValue;
            }

            records.Add(new BookVectorRecord(guidId, vector, metadata));
        }

        return records;
    }

    public async Task SaveStudentVectorAsync(StudentVectorRecord record)
    {
        if (!await _qdrantClient.CollectionExistsAsync(StudentCollectionName))
        {
            await _qdrantClient.CreateCollectionAsync(StudentCollectionName,
                new VectorParams { Size = 768, Distance = Distance.Cosine });
        }

        var point = new PointStruct
        {
            Id = (ulong)record.StudentId,
            Vectors = record.Vector
        };

        foreach (var meta in record.Metadata)
        {
            point.Payload.Add(meta.Key, meta.Value);
        }

        await _qdrantClient.UpsertAsync(StudentCollectionName, new[] { point });
    }

    public async Task<StudentVectorRecord?> GetStudentVectorAsync(long studentId)
    {
        if (!await _qdrantClient.CollectionExistsAsync(StudentCollectionName))
            return null;

        var points = await _qdrantClient.RetrieveAsync(
            collectionName: StudentCollectionName,
            ids: new List<PointId> { (ulong)studentId },
            withVectors: true,
            withPayload: true
        );

        var point = points.FirstOrDefault();
        if (point == null) return null;

        var vectorData = point.Vectors.Vector.Dense.Data;

        if (vectorData == null || vectorData.Count == 0)
            return null;

        var vector = vectorData.ToArray();

        var metadata = new Dictionary<string, string>();
        foreach (var p in point.Payload)
        {
            metadata[p.Key] = p.Value.StringValue;
        }

        return new StudentVectorRecord(studentId, vector, metadata);
    }

    public async Task<List<Guid>> GetTopRecommendationBooksIdsAsync(float[] studentVector, int limit = 5)
    {
        if (!await _qdrantClient.CollectionExistsAsync(CollectionName))
            return [];

        var searchResults = await _qdrantClient.SearchAsync(
            collectionName: CollectionName,
            vector: studentVector,
            limit: (ulong)limit
        );

        return searchResults
            .Select(result => Guid.Parse(result.Id.Uuid))
            .ToList();
    }
}

