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

    [Authorize(Roles = "Admin")]
    [HttpPost("registerAdmin")]
    public IActionResult RegisterAdmin([FromBody] RegisterRequest request)
    {
        _authenticationService.Register(request, Role.Admin);
        return StatusCode(StatusCodes.Status201Created, new { message = "Admin registered successfully." });
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("registerUser")]
    public IActionResult RegisterUser([FromBody] RegisterRequest request)
    {
        _authenticationService.Register(request, Role.User);
        return StatusCode(StatusCodes.Status201Created, new { message = "User registered successfully." });
    }

    [HttpPost("login")]
    public ActionResult<AuthResponse> Login([FromBody] LoginRequest request)
    {
        var response = _authenticationService.Login(request);
        return Ok(response);
    }
}
