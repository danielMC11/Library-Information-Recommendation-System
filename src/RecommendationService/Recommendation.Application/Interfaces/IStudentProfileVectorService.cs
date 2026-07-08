using Shared.Events;

namespace Recommendation.Application.Interfaces;

public interface IStudentProfileVectorService
{
    Task CalculateInitialProfileVector(StudentRegisteredEvent @event);
    Task RecalculateProfileVector(StudentInteractionsAccumulatedEvent @event);
}
