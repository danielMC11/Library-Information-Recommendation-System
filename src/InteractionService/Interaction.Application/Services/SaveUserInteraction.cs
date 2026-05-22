using Interaction.Application.Enums;
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

    public SaveUserInteraction(IUserInteractionRepository repository)
    {
        _repository = repository;
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
    }
}
