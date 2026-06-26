using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniIdentityApi.Application.DTOs.Auth;
using MiniIdentityApi.Application.Services;
using MiniIdentityApi.Domain.Entities;

namespace MiniIdentityApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthenticationService _authenticationService;

    public AuthController(AuthenticationService authenticationService)
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

    [HttpPost("registerStudent")]
    public IActionResult RegisterStudent([FromBody] RegisterStudentRequest request)
    {
        _authenticationService.RegisterStudent(request);
        return StatusCode(StatusCodes.Status201Created, new { message = "Student registered successfully." });
    }

    [HttpPost("login")]
    public ActionResult<AuthResponse> Login([FromBody] LoginRequest request)
    {
        var response = _authenticationService.Login(request);
        return Ok(response);
    }
}
