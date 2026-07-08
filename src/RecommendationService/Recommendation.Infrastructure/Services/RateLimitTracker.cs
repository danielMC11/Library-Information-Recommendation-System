using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Recommendation.Application.Interfaces;
using Recommendation.Infrastructure.Persistence;
using Shared.Config;
using Shared.Helpers;

namespace Recommendation.Infrastructure.Services;

public class RateLimitTracker : IRateLimitTracker
{
    private readonly int _maxRpm;
    private readonly int _maxTpm;
    private readonly int _maxRpd;

    private readonly RecommendationDbContext _dbContext;
    private readonly ILogger<RateLimitTracker> _logger;

    private static readonly SemaphoreSlim _lock = new(1, 1);

    public RateLimitTracker(RecommendationDbContext dbContext, ILogger<RateLimitTracker> logger, IOptions<RateLimitSettings> settings)
    {
        _maxRpm = settings.Value.MaxRpm;
        _maxTpm = settings.Value.MaxTpm;
        _maxRpd = settings.Value.MaxRpd;
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task<(bool WouldExceed, DateTime? ResumeAtUtc)> CheckAndUpdateLimitsAsync(int estimatedTokens)
    {
        await _lock.WaitAsync();
        try
        {
            var colombiaNow = ColombiaTimeHelper.Now;
            var today = DateOnly.FromDateTime(colombiaNow);

            var activeMinuteRow = await _dbContext.RateLimitStates
                .Where(r => r.MinuteEnd > colombiaNow)
                .OrderByDescending(r => r.MinuteStart)
                .FirstOrDefaultAsync();

            var activeMinuteRequestCount = activeMinuteRow?.RequestCount ?? 0;
            var activeMinuteTokenCount = activeMinuteRow?.TokenCount ?? 0;

            var dailyRequestCount = await _dbContext.RateLimitStates
                .Where(r => r.Date == today)
                .SumAsync(r => (long?)r.RequestCount) ?? 0;

            if (activeMinuteRequestCount + 1 > _maxRpm || activeMinuteTokenCount + estimatedTokens > _maxTpm)
            {
                var resumeAt = colombiaNow.AddSeconds(60);
                _logger.LogWarning("Minute sliding window limit exceeded. RPM: {Rpm}/{MaxRpm}, TPM: {Tpm}/{MaxTpm}. Window: {Start} -> {End}. Resuming at {ResumeAt}",
                    activeMinuteRequestCount + 1, _maxRpm, activeMinuteTokenCount + estimatedTokens, _maxTpm,
                    activeMinuteRow!.MinuteStart, activeMinuteRow.MinuteEnd, resumeAt);
                return (true, resumeAt);
            }

            if (dailyRequestCount + 1 > _maxRpd)
            {
                var resumeAt = colombiaNow.AddHours(24);
                _logger.LogWarning("Daily limit exceeded. RPD: {Rpd}/{MaxRpd}. Resuming at {ResumeAt}",
                    dailyRequestCount + 1, _maxRpd, resumeAt);
                return (true, resumeAt);
            }

            if (activeMinuteRow == null)
            {
                _dbContext.RateLimitStates.Add(new RateLimitState
                {
                    MinuteStart = colombiaNow,
                    MinuteEnd = colombiaNow.AddSeconds(60),
                    Date = today,
                    RequestCount = 1,
                    TokenCount = estimatedTokens
                });
            }
            else
            {
                activeMinuteRow.RequestCount++;
                activeMinuteRow.TokenCount += estimatedTokens;
            }

            await _dbContext.SaveChangesAsync();
            return (false, null);
        }
        finally
        {
            _lock.Release();
        }
    }
}
