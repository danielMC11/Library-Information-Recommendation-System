using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Config;

public class EventTopology
{
    public string Queue { get; set; } = string.Empty;
    public string RoutingKey { get; set; } = string.Empty;
}