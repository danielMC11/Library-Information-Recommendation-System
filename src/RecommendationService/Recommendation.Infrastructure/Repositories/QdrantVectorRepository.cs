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
}

