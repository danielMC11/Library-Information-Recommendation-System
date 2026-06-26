using System;

namespace Shared.Events;

public class StudentRegisteredEvent
{
    public Guid UserId { get; set; }
    public string Description { get; set; } = "";
}
