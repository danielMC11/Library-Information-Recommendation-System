using System;
using System.Collections.Generic;
using System.Text;

namespace Recommendation.Domain.Entities;


public record BookVectorRecord(
    Guid Id,
    float[] Vector, 
    Dictionary<string, string> Metadata);