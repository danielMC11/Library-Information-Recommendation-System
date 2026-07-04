using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Recommendation.Application.Interfaces;
using Recommendation.Domain.Entities;
using Shared.Config;
using Shared.Enums;
using Shared.Events;
using Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendation.Application.Services;

public class StudentProfileVectorService
{
    private readonly QdrantService _qdrantService;
    private readonly GeminiEmbeddingService _embeddingService;
    private readonly ILogger<StudentProfileVectorService> _logger;

    private readonly float _alpha;
    private const int VectorSize = 768;

    public StudentProfileVectorService(
        QdrantService qdrantService,
        GeminiEmbeddingService embeddingService,
        ILogger<StudentProfileVectorService> logger,
        IOptions<StudentVectorSettings> settings)
    {
        _qdrantService = qdrantService;
        _embeddingService = embeddingService;
        _logger = logger;
        _alpha = (float)settings.Value.Alpha;
    }

    public async Task CalculateInitialProfileVector(StudentRegisteredEvent @event)
    {
        var userVec = await _embeddingService.GenerateEmbeddingAsync(@event.Description);

        var record = new StudentVectorRecord(
            StudentId: @event.StudentId,
            Vector: userVec,
            Metadata: new Dictionary<string, string>());

        await _qdrantService.SaveStudentVectorAsync(record);

        _logger.LogInformation("Vector inicial generado para estudiante {StudentId}", @event.StudentId);
    }

    public async Task RecalculateProfileVector(StudentInteractionsAccumulatedEvent @event)
    {
        // 1. Traer el vector actual del estudiante
        var currentRecord = await _qdrantService.GetStudentVectorAsync(@event.StudentId);
        if (currentRecord == null)
        {
            _logger.LogWarning("No se encontr� vector para estudiante {StudentId}", @event.StudentId);
            return;
        }

        var userVec = currentRecord.Vector;

        // 2. Traer los vectores de todos los libros involucrados en las interacciones
        var bookIds = @event.Interactions.SelectMany(i => i.BookIds);
        var bookRecords = await _qdrantService.GetVectorsByBookIdsAsync(bookIds);
        var bookVecMap = bookRecords.ToDictionary(b => b.Id, b => b.Vector);

        // 3. Calcular el promedio ponderado (con soporte para pesos negativos)
        var weightedSum = new float[VectorSize];
        float totalAbsoluteWeight = 0f;

        foreach (var interaction in @event.Interactions)
        {
            if (!Enum.TryParse<InteractionType>(interaction.InteractionType, out var interactionType))
            {
                _logger.LogWarning("Tipo de interacci�n desconocido: {Type}", interaction.InteractionType);
                continue;
            }

            var weight = interactionType.GetWeight();

            foreach (var bookId in interaction.BookIds)
            {
                if (!bookVecMap.TryGetValue(bookId, out var bookVec))
                {
                    _logger.LogWarning("No se encontr� vector para libro {BookId}", bookId);
                    continue;
                }

                // Scalar multiplication: cada dimensi�n del book_vec se escala por el peso
                // Si el peso es negativo (UNFAVORITE), empuja el vector en direcci�n contraria
                for (int i = 0; i < VectorSize; i++)
                    weightedSum[i] += bookVec[i] * weight;

                // Valor absoluto para que UNFAVORITE no cancele el denominador
                totalAbsoluteWeight += Math.Abs(weight);
            }
        }

        if (totalAbsoluteWeight == 0f)
        {
            _logger.LogWarning("Peso total es 0, no se recalcula el vector del estudiante {StudentId}", @event.StudentId);
            return;
        }

        // 4. Dividir entre la suma de pesos absolutos para obtener el promedio ponderado
        var interactionVec = new float[VectorSize];
        for (int i = 0; i < VectorSize; i++)
            interactionVec[i] = weightedSum[i] / totalAbsoluteWeight;

        // 5. Mezclar: 40% perfil actual + 60% interacciones
        var blendedVec = new float[VectorSize];
        for (int i = 0; i < VectorSize; i++)
            blendedVec[i] = _alpha * userVec[i] + (1 - _alpha) * interactionVec[i];

        // 6. Normalizaci�n L2 para mantener el vector v�lido para similitud coseno en Qdrant
        // Especialmente importante cuando hay pesos negativos (UNFAVORITE)
        var normalizedVec = L2Normalize(blendedVec);

        // 7. Guardar el vector actualizado
        var updatedRecord = new StudentVectorRecord(
            StudentId: @event.StudentId,
            Vector: normalizedVec,
            Metadata: currentRecord.Metadata);

        await _qdrantService.SaveStudentVectorAsync(updatedRecord);

        _logger.LogInformation("Vector recalculado para estudiante {StudentId}", @event.StudentId);
    }

    private static float[] L2Normalize(float[] vector)
    {
        float magnitude = MathF.Sqrt(vector.Sum(v => v * v));

        if (magnitude == 0f) return vector;

        return vector.Select(v => v / magnitude).ToArray();
    }
}
