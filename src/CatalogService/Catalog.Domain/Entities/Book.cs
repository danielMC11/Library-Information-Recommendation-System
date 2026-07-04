using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Entities;

public class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Isbn { get; set; }
    public string Title { get; set; } = null!;
    public string? Language { get; set; }
    public string? Year { get; set; }
    public string? Summary { get; set; }

    public ICollection<Author> Authors { get; set; } = new HashSet<Author>();
    public virtual ICollection<Topic> Topics { get; set; } = new HashSet<Topic>();


    public override bool Equals(object? obj)
    {
        if (obj is not Book other) return false;

        // Si ambos tienen ISBN, comparamos por ISBN
        if (!string.IsNullOrEmpty(Isbn) && !string.IsNullOrEmpty(other.Isbn))
            return Isbn == other.Isbn;

        // Si no hay ISBN, comparamos Título y primer Autor (Clave natural)
        var normalTitle = Title?.Trim().ToLower();
        var otherNormalTitle = other.Title?.Trim().ToLower();

        var firstAuthor = Authors.FirstOrDefault()?.Name?.Trim().ToLower();
        var otherFirstAuthor = other.Authors.FirstOrDefault()?.Name?.Trim().ToLower();

        return normalTitle == otherNormalTitle && firstAuthor == otherFirstAuthor;
    }

    public override string ToString()
    {
        var textParts = new List<string> { $"Título: {Title}" };

        if (!string.IsNullOrWhiteSpace(Summary))
            textParts.Add($"Resumen: {Summary}");

        // Procesar Autores mapeando a su propiedad 'Name'
        if (Authors != null && Authors.Any())
        {
            var authorNames = Authors.Select(a => a.Name).Where(name => !string.IsNullOrWhiteSpace(name));
            if (authorNames.Any() && authorNames.First() != "Author")
            {
                textParts.Add($"Autores: {string.Join(", ", authorNames)}");
            }
        }

        // Procesar Temas mapeando a su propiedad 'Name'
        if (Topics != null && Topics.Any())
        {
            var topicNames = Topics.Select(t => t.Name).Where(name => !string.IsNullOrWhiteSpace(name));
            if (topicNames.Any())
            {
                textParts.Add($"Temas: {string.Join(", ", topicNames)}");
            }
        }

        return string.Join(". ", textParts) + ".";
    }

}
