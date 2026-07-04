namespace Shared.Events;

public class StudentInteractionEvent
{
    public long StudentId { get; set; }
    public StudentInteractionItem Interaction { get; set; } = null!;
}
