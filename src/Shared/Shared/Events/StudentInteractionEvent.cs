
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Events;

public class StudentInteractionEvent
{
    public List<Guid> BookIds { get; set; } = new List<Guid>();
    public long StudentId { get; set; }
    public string InteractionType { get; set; } = "";

}
