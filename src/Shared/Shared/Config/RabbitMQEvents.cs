using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Config;

public class RabbitMQEvents
{
    public EventTopology BooksUploaded { get; set; } = new();
    public EventTopology UserInteractionsAccumulated { get; set; } = new();
}

