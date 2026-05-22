using System;
using System.Collections.Generic;

namespace Recommendation.Application.Events;

public class UserProfileCalculationEvent
{
    public Guid UserId { get; set; }
    public List<Guid> BookIds { get; set; } = new List<Guid>();
}
