namespace MiniIdentityApi.Application.DTOs.Auth;

public class RegisterStudentRequest
{
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int CareerId { get; set; }
    public int SemesterNumber { get; set; }
    public List<int> SubjectIds { get; set; } = new();
}
