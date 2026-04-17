namespace MiniIdentityApi.Application.DTOs.Auth;

public class AuthResponse
{
    public Guid Id { get; set; }
    public string AccessToken { get; set; } = string.Empty;
    public string TokenType { get; set; } = "Bearer";
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Career { get; set; }
    public int Semester { get; set; }
    public List<string> Roles { get; set; } = new();
}