using Interaction.Domain.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interaction.Domain.Events;

public class UserInteractionEvent
{

    public InteractionType InteractionType { get; set; }

}

