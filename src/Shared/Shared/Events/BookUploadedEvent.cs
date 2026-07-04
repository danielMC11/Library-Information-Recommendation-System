namespace Shared.Events;

public class BookUploadedEvent
{
    public Guid Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public string? Isbn { get; set; }
    public string? Year { get; set; }
    public string? Language { get; set; }
}
