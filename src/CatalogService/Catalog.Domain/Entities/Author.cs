using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

public class Author
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;

    public ICollection<Book> Books { get; set; } = new HashSet<Book>();
}