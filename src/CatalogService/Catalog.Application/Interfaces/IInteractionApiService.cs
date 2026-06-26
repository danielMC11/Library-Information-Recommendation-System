using Shared.Events;

namespace Catalog.Application.Interfaces;

public interface IInteractionApiService
{
    Task SendStudentInteractionAsync(StudentInteractionEvent interactionEvent);
}
