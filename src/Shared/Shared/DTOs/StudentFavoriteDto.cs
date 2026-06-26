namespace Shared.DTOs;

public class StudentFavoriteDto
{
    public Guid Id { get; set; }
    public long StudentId { get; set; }
    public Guid BookId { get; set; }
    public DateTime CreatedAt { get; set; }
}