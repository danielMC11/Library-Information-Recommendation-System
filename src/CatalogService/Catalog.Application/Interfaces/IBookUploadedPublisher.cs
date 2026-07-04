using Shared.Events;

namespace Catalog.Application.Interfaces;

public interface IBookUploadedPublisher
{
   Task PublishAsync(BookUploadedEvent @event);
}
