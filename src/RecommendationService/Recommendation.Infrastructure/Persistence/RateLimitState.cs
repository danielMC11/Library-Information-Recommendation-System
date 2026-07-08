using System.ComponentModel.DataAnnotations;

namespace Recommendation.Infrastructure.Persistence;

public class RateLimitState
{
    [Key]
    public int Id { get; set; }

    public DateTime MinuteStart { get; set; }

    public DateTime MinuteEnd { get; set; }

    public DateOnly Date { get; set; }

    public int RequestCount { get; set; }

    public int TokenCount { get; set; }
}
