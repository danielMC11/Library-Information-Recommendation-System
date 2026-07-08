namespace Auth.Application.DTOs;

public class StudentListItemDto
{
    public long StudentId { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string CareerName { get; set; } = null!;
}
