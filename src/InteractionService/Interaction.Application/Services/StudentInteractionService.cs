using Interaction.Domain.enums;
using Shared.Events;
using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interaction.Application.Services;

public class StudentInteractionService
{
    private readonly IStudentInteractionRepository _repository;
    private readonly IStudentInteractionsAccumulatedPublisher _publisher;

    public StudentInteractionService(IStudentInteractionRepository repository, IStudentInteractionsAccumulatedPublisher publisher)
    {
        _repository = repository;
        _publisher = publisher;
    }

    public async Task ExecuteAsync(StudentInteractionEvent studentInteractionEvent)
    {
        if (studentInteractionEvent.StudentId == 0)
            throw new ArgumentException("StudentId cannot be empty.", nameof(studentInteractionEvent));

        if (studentInteractionEvent.BookIds == null || !studentInteractionEvent.BookIds.Any())
            throw new ArgumentException("BookIds cannot be null or empty.", nameof(studentInteractionEvent));

        if (!Enum.TryParse<Interaction.Domain.enums.InteractionType>(studentInteractionEvent.InteractionType, true, out var interactionType))
            throw new ArgumentException($"Invalid interaction type: {studentInteractionEvent.InteractionType}", nameof(studentInteractionEvent));

        var interactionEvents = studentInteractionEvent.BookIds.Select(bookId => new InteractionEvent
        {
            StudentId = studentInteractionEvent.StudentId,
            BookId = bookId,
            Type = interactionType,
            Timestamp = DateTime.UtcNow
        }).ToList();

        await _repository.SaveStudentInteractionAsync(interactionEvents);

        var studentInteractions = await _repository.GetStudentInteractionsAsync(studentInteractionEvent.StudentId);

        if (studentInteractions.Count == 3)
        {
            var profileEvent = new StudentInteractionsAccumulatedEvent
            {
                StudentId = studentInteractionEvent.StudentId,
                BookIds = studentInteractions.Select(i => i.BookId).Distinct().ToList()
            };
            await _publisher.PublishAsync(profileEvent);
        }
    }
}
