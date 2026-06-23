using Shared.Events;

namespace Catalog.Application.Interfaces;

public interface IInteractionApiService
{
    Task SendUserInteractionAsync(UserInteractionEvent interactionEvent);
}
