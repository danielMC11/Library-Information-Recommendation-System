namespace Interaction.Domain.Entities;

public class StudentFavorite
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public long StudentId { get; set; }
    public Guid BookId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}