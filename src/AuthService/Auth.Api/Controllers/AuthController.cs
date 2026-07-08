using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Auth.Application.DTOs.Auth;
using Auth.Application.Interfaces;
using Auth.Domain.Entities;

namespace Auth.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [Authorize(Roles = "ADMIN")]
    [HttpPost("registerAdmin")]
    public IActionResult RegisterAdmin([FromBody] RegisterRequest request)
    {
        _authenticationService.RegisterAdmin(request);
        return StatusCode(StatusCodes.Status201Created, new { message = "Admin registered successfully." });
    }

    [Authorize(Roles = "ADMIN")]
    [HttpPost("registerStudent")]
    public async Task<IActionResult> RegisterStudent([FromBody] RegisterStudentRequest request)
    {
        await _authenticationService.RegisterStudent(request);
        return StatusCode(StatusCodes.Status201Created, new { message = "Student registered successfully." });
    }

    [HttpPost("login")]
    public ActionResult<AuthResponse> Login([FromBody] LoginRequest request)
    {
        var response = _authenticationService.Login(request);
        return Ok(response);
    }
}
