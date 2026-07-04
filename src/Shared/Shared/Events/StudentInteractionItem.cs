using System;
using System.Collections.Generic;

namespace Shared.Events;

public class StudentInteractionItem
{
    public List<Guid> BookIds { get; set; } = new();
    public string InteractionType { get; set; } = "";
}
