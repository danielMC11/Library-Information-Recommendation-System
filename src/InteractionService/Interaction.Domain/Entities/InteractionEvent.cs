using Interaction.Domain.enums;
using System;

namespace Interaction.Domain.Entities;

public class InteractionEvent
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }
    public InteractionType Type { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
