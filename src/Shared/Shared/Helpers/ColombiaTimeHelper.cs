namespace Shared.Helpers;

public static class ColombiaTimeHelper
{
    public static DateTime Now => DateTime.UtcNow.AddHours(-5);
}
