using Microsoft.Extensions.Configuration;
using Recommendation.Application.Events;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using Recommendation.Domain.Entities;


namespace Recommendation.Application.Services;


public class ProcessBooksBatchService
{

    private readonly GeminiEmbeddingService _geminiEmbeddingService;
    private readonly QdrantService _qdrantService;
    private readonly ILogger<ProcessBooksBatchService> _logger;

    public ProcessBooksBatchService(GeminiEmbeddingService geminiEmbeddingService, QdrantService qdrantService, ILogger<ProcessBooksBatchService> logger)
    {
        _geminiEmbeddingService = geminiEmbeddingService;
        _qdrantService = qdrantService;
        _logger = logger;
    }


    public async Task ProcessEmbeddingsAsync(NewBookBatchEvent @event)
    {
        var records = new List<BookVectorRecord>();

        foreach (var book in @event.Books)
        {
            _logger.LogInformation("Procesando embedding para BookId: {BookId}", book.BookId);
             
            try
            {
                var vector = await _geminiEmbeddingService.GenerateEmbeddingAsync(book.Text);

                var metadata = new Dictionary<string, string>
                {
                    { "bookId", book.BookId.ToString() }
                };

                records.Add(new BookVectorRecord(book.BookId, vector, metadata));

                // Límite de 80 peticiones por minuto a Gemini (60000ms / 80 = 750ms)
                await Task.Delay(750);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al generar embedding para BookId: {BookId}", book.BookId);
            }
        }

        if (records.Count > 0)
        {
            await _qdrantService.SaveBatchAsync(records);
            _logger.LogInformation("Lote de {Count} vectores guardado en Qdrant exitosamente.", records.Count);
        }
    }
}
