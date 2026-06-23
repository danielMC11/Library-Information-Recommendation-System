using System;
using System.Collections.Generic;

namespace Shared.Events;

public class UserInteractionsAccumulatedEvent
{
    public Guid UserId { get; set; }
    public List<Guid> BookIds { get; set; } = new List<Guid>();
}
