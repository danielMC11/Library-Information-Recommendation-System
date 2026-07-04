namespace Shared.Config;
public class RateLimitSettings
{
    public const string SectionName = "RateLimit";

    public int MaxRpm { get; set; }
    public int MaxTpm { get; set; }
    public int MaxRpd { get; set; }
}
