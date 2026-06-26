using System;
using System.Collections.Generic;

namespace Shared.Events;

public class StudentInteractionsAccumulatedEvent
{
    public long StudentId { get; set; }
    public List<Guid> BookIds { get; set; } = new List<Guid>();
}
