using System;

namespace Shared.Events;

public class StudentRegisteredEvent
{
    public long StudentId { get; set; }
    public string Description { get; set; } = "";
}
