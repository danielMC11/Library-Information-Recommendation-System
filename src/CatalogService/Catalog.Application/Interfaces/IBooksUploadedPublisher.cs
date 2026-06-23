using Shared.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Interfaces;

public interface IBooksUploadedPublisher
{
   Task PublishAsync(BooksUploadedEvent @event);

}
