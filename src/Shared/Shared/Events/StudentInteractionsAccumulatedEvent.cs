using System.Collections.Generic;

namespace Shared.Events;

public class StudentInteractionsAccumulatedEvent
{
    public long StudentId { get; set; }
    public List<StudentInteractionItem> Interactions { get; set; } = new();
}
