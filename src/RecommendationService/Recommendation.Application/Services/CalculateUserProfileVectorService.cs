using Microsoft.Extensions.Logging;
using Shared.Events;
using Recommendation.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendation.Application.Services;

public class CalculateUserProfileVectorService
{
    private readonly IVectorRepository _vectorRepository;
    private readonly ILogger<CalculateUserProfileVectorService> _logger;

    public CalculateUserProfileVectorService(IVectorRepository vectorRepository, ILogger<CalculateUserProfileVectorService> logger)
    {
        _vectorRepository = vectorRepository;
        _logger = logger;
    }

    public async Task CalculateAndSaveProfileVectorAsync(UserInteractionsAccumulatedEvent @event)
    {
        if (@event.BookIds == null || !@event.BookIds.Any())
        {
            _logger.LogWarning("No book IDs provided for user profile calculation. UserId: {UserId}", @event.UserId);
            return;
        }

        // Fetch vectors for the provided books
        var bookVectors = await _vectorRepository.GetVectorsByBookIdsAsync(@event.BookIds);

        if (!bookVectors.Any())
        {
            _logger.LogWarning("No vectors found for the provided book IDs. UserId: {UserId}", @event.UserId);
            return;
        }

        // Calculate Weighted Average Vector (Simple Average for now)
        int vectorSize = bookVectors.First().Vector.Length;
        var averageVector = new float[vectorSize];

        foreach (var bookVector in bookVectors)
        {
            for (int i = 0; i < vectorSize; i++)
            {
                averageVector[i] += bookVector.Vector[i];
            }
        }

        for (int i = 0; i < vectorSize; i++)
        {
            averageVector[i] /= bookVectors.Count;
        }

        _logger.LogInformation("Successfully calculated User Profile Vector for UserId: {UserId}. Vector Size: {Size}", @event.UserId, vectorSize);

        // TODO: Save the user profile vector to Qdrant or Database based on further requirements.
        // For now, we log the success.
    }
}
