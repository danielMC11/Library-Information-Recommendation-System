namespace Auth.Application.DTOs;

public class CareerDetailDto
{
    public int Id { get; set; }
    public string CareerName { get; set; } = null!;
    public int DurationSemesters { get; set; }
    public int Semester { get; set; }
    public List<SubjectDto> Subjects { get; set; } = [];
}
