using System;
using System.Collections.Generic;
using System.Text;

public record BookDetailsDto
{
    public Guid Id { get; init; }
    public string? Isbn { get; init; }
    public string Title { get; init; } = null!;
    public string? Classification { get; init; }
    public string? Language { get; init; }
    public string? Year { get; init; }
    public string? Summary { get; init; }

    public IEnumerable<string> Authors { get; init; } = Enumerable.Empty<string>();
    public IEnumerable<string> Topics { get; init; } = Enumerable.Empty<string>();
}