namespace Auth.Application.DTOs;

public class StudentDetailDto
{
    public long StudentId { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string CareerName { get; set; } = null!;
    public List<SubjectDto> Subjects { get; set; } = [];
}
