using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Entities;

public class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Isbn { get; set; }
    public string Title { get; set; } = null!;
    public string? Classification { get; set; }
    public string? Language { get; set; }
    public string? Year { get; set; }
    public string? Summary { get; set; }

    public ICollection<Author> Authors { get; set; } = new HashSet<Author>();
    public virtual ICollection<Topic> Topics { get; set; } = new HashSet<Topic>();
}
