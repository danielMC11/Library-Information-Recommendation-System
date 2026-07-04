namespace Shared.Config;

public class InteractionAccumulationSettings
{
    public const string SectionName = "InteractionAccumulation";
    public int BatchSize { get; set; } = 3;
}
