using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Auth.Application.DTOs.Auth;
using Auth.Application.Interfaces;
using Auth.Domain.Entities;

namespace Auth.Api.Controllers;

[ApiController]
[Route("api/auth/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    /// <summary>Registra un nuevo administrador.</summary>
    /// <param name="request">Datos del administrador a registrar (username, email, password).</param>
    /// <returns>Código 201 con mensaje de confirmación.</returns>
    [Authorize(Roles = "ADMIN")]
    [HttpPost("registerAdmin")]
    public IActionResult RegisterAdmin([FromBody] RegisterRequest request)
    {
        _authenticationService.RegisterAdmin(request);
        return StatusCode(StatusCodes.Status201Created, new { message = "Admin registered successfully." });
    }

    /// <summary>Registra un nuevo estudiante.</summary>
    /// <param name="request">Datos del estudiante a registrar (username, email, password, careerId, subjectIds).</param>
    /// <returns>Código 201 con mensaje de confirmación.</returns>
    [Authorize(Roles = "ADMIN")]
    [HttpPost("registerStudent")]
    public async Task<IActionResult> RegisterStudent([FromBody] RegisterStudentRequest request)
    {
        await _authenticationService.RegisterStudent(request);
        return StatusCode(StatusCodes.Status201Created, new { message = "Student registered successfully." });
    }

    /// <summary>Autentica un usuario y devuelve un token JWT.</summary>
    /// <param name="request">Credenciales del usuario (usernameOrEmail, password).</param>
    /// <returns>Token JWT con información del usuario autenticado.</returns>
    [HttpPost("login")]
    public ActionResult<AuthResponse> Login([FromBody] LoginRequest request)
    {
        try
        {
            var response = _authenticationService.Login(request);
            return Ok(response);
        }
        catch (UnauthorizedAccessException)
        {
            return BadRequest(new { message = "Invalid credentials." });
        }
    }
}
