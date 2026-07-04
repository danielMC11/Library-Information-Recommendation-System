using System.Collections.Generic;

namespace Recommendation.Domain.Entities;

public record StudentVectorRecord(
    long StudentId,
    float[] Vector,
    Dictionary<string, string> Metadata);
