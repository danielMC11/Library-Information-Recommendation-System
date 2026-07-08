using Microsoft.Extensions.Options;
using Shared.Config;
using Shared.Events;
using Shared.Enums;
using Shared.Helpers;
using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interaction.Application.Services;

public class StudentInteractionService : IStudentInteractionService
{
    private readonly IStudentInteractionRepository _repository;
    private readonly IStudentInteractionsAccumulatedPublisher _publisher;
    private readonly int _batchSize;

    public StudentInteractionService(
        IStudentInteractionRepository repository,
        IStudentInteractionsAccumulatedPublisher publisher,
        IOptions<InteractionAccumulationSettings> settings)
    {
        _repository = repository;
        _publisher = publisher;
        _batchSize = settings.Value.BatchSize;
    }

    public async Task ExecuteAsync(StudentInteractionEvent studentInteractionEvent)
    {
        if (studentInteractionEvent.StudentId == 0)
            throw new ArgumentException("StudentId cannot be empty.", nameof(studentInteractionEvent));

        if (studentInteractionEvent.Interaction == null ||
            studentInteractionEvent.Interaction.BookIds == null ||
            !studentInteractionEvent.Interaction.BookIds.Any())
            throw new ArgumentException("BookIds cannot be null or empty.", nameof(studentInteractionEvent));

        if (!Enum.TryParse<InteractionType>(studentInteractionEvent.Interaction.InteractionType, true, out var interactionType))
            throw new ArgumentException($"Invalid interaction type: {studentInteractionEvent.Interaction.InteractionType}", nameof(studentInteractionEvent));

        var interactionEvents = studentInteractionEvent.Interaction.BookIds.Select(bookId => new InteractionEvent
        {
            StudentId = studentInteractionEvent.StudentId,
            BookId = bookId,
            Type = interactionType,
            Timestamp = ColombiaTimeHelper.Now
        }).ToList();

        await _repository.SaveStudentInteractionAsync(interactionEvents);

        var studentInteractions = await _repository.GetStudentInteractionsAsync(studentInteractionEvent.StudentId);

        if (studentInteractions.Count >= _batchSize)
        {
            var profileEvent = new StudentInteractionsAccumulatedEvent
            {
                StudentId = studentInteractionEvent.StudentId,
                Interactions = studentInteractions.Select(i => new StudentInteractionItem
                {
                    BookIds = new List<Guid> { i.BookId },
                    InteractionType = i.Type.ToString()
                }).ToList()
            };
            await _publisher.PublishAsync(profileEvent);
            await _repository.DeleteStudentInteractionsAsync(studentInteractionEvent.StudentId);
        }
    }
}
