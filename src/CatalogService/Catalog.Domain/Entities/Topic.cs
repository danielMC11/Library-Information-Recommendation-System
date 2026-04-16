using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Entities;

public class Topic
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;

    public ICollection<Book> Books { get; set; } = new HashSet<Book>();
}