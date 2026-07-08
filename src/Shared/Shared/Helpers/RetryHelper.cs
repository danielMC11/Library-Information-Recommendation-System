using Microsoft.Extensions.Logging;

namespace Shared.Helpers;

public static class RetryHelper
{
    public static async Task RetryOnExceptionAsync(Func<CancellationToken, Task> operation, ILogger logger, string operationName, CancellationToken cancellationToken)
    {
        var maxRetries = 5;
        var delay = TimeSpan.FromSeconds(1);

        for (var attempt = 1; attempt <= maxRetries; attempt++)
        {
            try
            {
                await operation(cancellationToken);
                return;
            }
            catch (Exception ex) when (attempt < maxRetries && !cancellationToken.IsCancellationRequested)
            {
                logger.LogWarning(ex, "Attempt {Attempt}/{MaxRetries} failed for {Operation}. Retrying in {Delay}...",
                    attempt, maxRetries, operationName, delay);
                await Task.Delay(delay, cancellationToken);
                delay = TimeSpan.FromMilliseconds(Math.Min(delay.TotalMilliseconds * 2, 30_000));
            }
        }

        try
        {
            await operation(cancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "All {MaxRetries} attempts failed for {Operation}.", maxRetries, operationName);
        }
    }
}
