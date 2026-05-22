using Interaction.Domain.enums;
using Interaction.Application.Events;
using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interaction.Application.Services;

public class SaveUserInteraction
{
    private readonly IUserInteractionRepository _repository;
    private readonly IUserProfilePublisher _publisher;

    public SaveUserInteraction(IUserInteractionRepository repository, IUserProfilePublisher publisher)
    {
        _repository = repository;
        _publisher = publisher;
    }

    public async Task ExecuteAsync(UserInteractionEvent userInteractionEvent)
    {
        if (userInteractionEvent.UserId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userInteractionEvent));

        if (userInteractionEvent.BookIds == null || !userInteractionEvent.BookIds.Any())
            throw new ArgumentException("BookIds cannot be null or empty.", nameof(userInteractionEvent));

        if (!Enum.TryParse<Interaction.Domain.enums.InteractionType>(userInteractionEvent.InteractionType, true, out var interactionType))
            throw new ArgumentException($"Invalid interaction type: {userInteractionEvent.InteractionType}", nameof(userInteractionEvent));

        var interactionEvents = userInteractionEvent.BookIds.Select(bookId => new InteractionEvent
        {
            UserId = userInteractionEvent.UserId,
            BookId = bookId,
            Type = interactionType,
            Timestamp = DateTime.UtcNow
        }).ToList();

        await _repository.SaveUserInteractionAsync(interactionEvents);

        // Check total interactions for the user
        var userInteractions = await _repository.GetUserInteractionsAsync(userInteractionEvent.UserId);
        
        // Ensure we only trigger when exactly 3 records are reached
        if (userInteractions.Count == 3)
        {
            var profileEvent = new UserProfileCalculationEvent
            {
                UserId = userInteractionEvent.UserId,
                BookIds = userInteractions.Select(i => i.BookId).Distinct().ToList()
            };
            await _publisher.PublishUserProfileCalculationEventAsync(profileEvent);
        }
    }
}
