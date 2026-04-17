using System;
using System.Collections.Generic;

namespace Catalog.Api.DTOs;

public class BookDto
{
    public Guid Id { get; set; }
    public string? Isbn { get; set; }
    public string Title { get; set; } = null!;
    public string? Classification { get; set; }
    public string? Language { get; set; }
    public string? Year { get; set; }
    public string? Summary { get; set; }
    
    // Aplanamos las listas: en vez de objetos completos, enviamos solo los nombres
    public List<string> Authors { get; set; } = new();
    public List<string> Topics { get; set; } = new();
}