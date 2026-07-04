using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Recommendation.Infrastructure.Persistence;
using Shared.Config;

namespace Recommendation.Infrastructure.Services;

public class RateLimitTracker
{
    private readonly int _maxRpm;
    private readonly int _maxTpm;
    private readonly int _maxRpd;

    private readonly RecommendationDbContext _dbContext;
    private readonly ILogger<RateLimitTracker> _logger;

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
        var colombiaNow = DateTime.UtcNow.AddHours(-5);
        var minuteBucket = new DateTime(colombiaNow.Year, colombiaNow.Month, colombiaNow.Day, colombiaNow.Hour, colombiaNow.Minute, 0, DateTimeKind.Utc);
        var today = DateOnly.FromDateTime(colombiaNow);

        var minuteRow = await _dbContext.RateLimitStates
            .FirstOrDefaultAsync(r => r.Minute == minuteBucket);

        var minuteRequestCount = minuteRow?.RequestCount ?? 0;
        var minuteTokenCount = minuteRow?.TokenCount ?? 0;

        var dailyRequestCount = await _dbContext.RateLimitStates
            .Where(r => r.Date == today)
            .SumAsync(r => (long?)r.RequestCount) ?? 0;

        if (minuteRequestCount + 1 > _maxRpm || minuteTokenCount + estimatedTokens > _maxTpm)
        {
            var resumeAt = minuteBucket.AddMinutes(1).AddSeconds(10);
            _logger.LogWarning("Minute limit exceeded. RPM: {Rpm}/{MaxRpm}, TPM: {Tpm}/{MaxTpm}. Resuming at {ResumeAt}",
                minuteRequestCount + 1, _maxRpm, minuteTokenCount + estimatedTokens, _maxTpm, resumeAt);
            return (true, resumeAt);
        }

        if (dailyRequestCount + 1 > _maxRpd)
        {
            var resumeAt = today.AddDays(1).ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc).AddMinutes(5);
            _logger.LogWarning("Daily limit exceeded. RPD: {Rpd}/{MaxRpd}. Resuming at {ResumeAt}",
                dailyRequestCount + 1, _maxRpd, resumeAt);
            return (true, resumeAt);
        }

        if (minuteRow == null)
        {
            _dbContext.RateLimitStates.Add(new RateLimitState
            {
                Minute = minuteBucket,
                Date = today,
                RequestCount = 1,
                TokenCount = estimatedTokens
            });
        }
        else
        {
            minuteRow.RequestCount++;
            minuteRow.TokenCount += estimatedTokens;
        }

        await _dbContext.SaveChangesAsync();
        return (false, null);
    }
}
