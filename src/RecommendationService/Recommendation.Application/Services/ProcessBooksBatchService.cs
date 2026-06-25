using Microsoft.Extensions.Configuration;
using Shared.Events;
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


    public async Task ProcessEmbeddingsAsync(BooksUploadedEvent @event)
    {
        var records = new List<BookVectorRecord>();

        foreach (var book in @event.Books)
        {
            _logger.LogInformation("Procesando embedding para BookId: {BookId}", book.Id);
             
            try
            {
                var vector = await _geminiEmbeddingService.GenerateEmbeddingAsync(book.Description);

                var metadata = new Dictionary<string, string>
                {
                    { "bookId", book.Id.ToString() },
                    { "isbn", book.Isbn ?? "" },
                    { "year", book.Year ?? "" },
                    { "language", book.Language ?? "" }
                };

                records.Add(new BookVectorRecord(book.Id, vector, metadata));

                // Límite de 80 peticiones por minuto a Gemini (60000ms / 80 = 750ms)
                await Task.Delay(750);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al generar embedding para BookId: {BookId}", book.Id);
            }
        }

        if (records.Count > 0)
        {
            await _qdrantService.SaveBatchAsync(records);
            _logger.LogInformation("Lote de {Count} vectores guardado en Qdrant exitosamente.", records.Count);
        }
    }
}
