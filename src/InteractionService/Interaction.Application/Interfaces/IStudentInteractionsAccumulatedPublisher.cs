using Shared.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interaction.Application.Interfaces;

public interface IStudentInteractionsAccumulatedPublisher
{

    Task PublishAsync(StudentInteractionsAccumulatedEvent @event);

}
