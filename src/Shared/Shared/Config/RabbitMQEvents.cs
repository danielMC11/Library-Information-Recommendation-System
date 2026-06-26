using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Config;

public class RabbitMQEvents
{
    public EventTopology StudentRegistered { get; set; } = new();
    public EventTopology BooksUploaded { get; set; } = new();
    public EventTopology StudentInteractionsAccumulated { get; set; } = new();
}

