using Interaction.Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interaction.Application.Events;

public class UserInteractionEvent
{
    public List<Guid> BookIds { get; set; } = new List<Guid>();
    public Guid UserId { get; set; }
    public string InteractionType { get; set; } = "";

}

