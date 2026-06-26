using Interaction.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interaction.Application.Interfaces;

public interface IStudentInteractionRepository
{
    Task SaveStudentInteractionAsync(IEnumerable<InteractionEvent> interactionEvents);
    Task<List<InteractionEvent>> GetStudentInteractionsAsync(long studentId);
}
