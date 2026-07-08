using Shared.Events;

namespace Interaction.Application.Interfaces;

public interface IStudentInteractionService
{
    Task ExecuteAsync(StudentInteractionEvent studentInteractionEvent);
}
