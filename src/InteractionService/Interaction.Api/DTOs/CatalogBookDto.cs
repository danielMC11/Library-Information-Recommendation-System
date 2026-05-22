using System;
using System.Collections.Generic;

namespace Interaction.Api.DTOs;

public class CatalogBookDto
{
    public Guid Id { get; set; }
    public string? Isbn { get; set; }
    public string Title { get; set; } = null!;
    public string? Classification { get; set; }
    public string? Language { get; set; }
    public string? Year { get; set; }
    public string? Summary { get; set; }
    public List<string> Authors { get; set; } = new();
    public List<string> Topics { get; set; } = new();
}
