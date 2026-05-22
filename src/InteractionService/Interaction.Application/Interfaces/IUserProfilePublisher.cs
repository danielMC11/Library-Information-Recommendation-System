using Interaction.Application.Events;
using System.Threading.Tasks;

namespace Interaction.Application.Interfaces;

public interface IUserProfilePublisher
{
    Task PublishUserProfileCalculationEventAsync(UserProfileCalculationEvent @event);
}
