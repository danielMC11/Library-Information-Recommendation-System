using Shared.Enums;
using System;

namespace Interaction.Domain.Entities;

public class InteractionEvent
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public long StudentId { get; set; }
    public Guid BookId { get; set; }
    public InteractionType Type { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
