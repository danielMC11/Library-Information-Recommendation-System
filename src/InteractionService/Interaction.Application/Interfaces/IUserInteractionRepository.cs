using Interaction.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interaction.Application.Interfaces;

public interface IUserInteractionRepository
{
    Task SaveUserInteractionAsync(IEnumerable<InteractionEvent> interactionEvents);
}
