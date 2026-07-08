using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Shared.Config;
using Shared.Events;
using Recommendation.Application.Interfaces;

namespace Recommendation.Infrastructure.Messaging;

public class StudentRegisteredListener : RateLimitedRabbitListenerBase<StudentRegisteredEvent>
{
    public StudentRegisteredListener(
        IOptions<RabbitMQSettings> settings,
        ILogger<StudentRegisteredListener> logger,
        IServiceScopeFactory scopeFactory)
        : base(settings, logger, scopeFactory) { }

    protected override string QueueName => _settings.Events.StudentRegistered.Queue;
    protected override string ResumeConfigKey => "GeminiResumeAtUtc";
    protected override int EstimateTokens(StudentRegisteredEvent @event) => @event.Description?.Length / 4 ?? 0;

    protected override async Task ProcessMessageAsync(StudentRegisteredEvent @event, IServiceScope scope)
    {
        var profileService = scope.ServiceProvider.GetRequiredService<IStudentProfileVectorService>();
        await profileService.CalculateInitialProfileVector(@event);
    }
}
