using Shared.Events;

namespace MiniIdentityApi.Application.Interfaces;

public interface IStudentRegisteredPublisher
{
    Task PublishAsync(StudentRegisteredEvent @event);
}
