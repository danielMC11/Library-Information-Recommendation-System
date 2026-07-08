using Auth.Application.DTOs.Auth;

namespace Auth.Application.Interfaces;

public interface IAuthenticationService
{
    void RegisterAdmin(RegisterRequest request);
    Task RegisterStudent(RegisterStudentRequest request);
    AuthResponse Login(LoginRequest request);
}
