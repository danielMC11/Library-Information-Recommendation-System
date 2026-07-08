namespace Recommendation.Application.Interfaces;

public interface IRateLimitTracker
{
    Task<(bool WouldExceed, DateTime? ResumeAtUtc)> CheckAndUpdateLimitsAsync(int estimatedTokens);
}
