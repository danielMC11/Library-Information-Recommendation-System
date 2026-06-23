using Shared.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interaction.Application.Interfaces;

public interface IUserInteractionsAccumulatedPublisher
{

    Task PublishAsync(UserInteractionsAccumulatedEvent @event);

}

