using Shared.Events;

namespace Auth.Application.Interfaces;

public interface IStudentRegisteredPublisher
{
    Task PublishAsync(StudentRegisteredEvent @event);
}
