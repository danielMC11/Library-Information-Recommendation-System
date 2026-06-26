using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Config;
public class RabbitMQExchanges
{
    public string Auth { get; set; } = string.Empty;
    public string Catalog { get; set; } = string.Empty;
    public string Interaction { get; set; } = string.Empty;
}