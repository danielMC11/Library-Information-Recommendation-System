using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniIdentityApi.Application.DTOs.Users;
using MiniIdentityApi.Application.Services;
using System.IdentityModel.Tokens.Jwt;

namespace MiniIdentityApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;

    public UsersController(UserService userService)
    {
        _userService = userService;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetAll());
    }

    [Authorize]
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var user = _userService.GetById(id);
        return user is null ? NotFound() : Ok(user);
    }

    [Authorize]
    [HttpPatch("{id:guid}/career-semester")]
    public IActionResult UpdateCareerAndSemester(Guid id, [FromBody] UpdateCareerAndSemesterRequest request)
    {
        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
            ?? User.FindFirst("sub")?.Value
            ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        var isAdmin = User.IsInRole("Admin");

        if (!isAdmin)
        {
            if (string.IsNullOrEmpty(userIdClaim))
                return Unauthorized(new { message = "Token inválido: no contiene el identificador de usuario." });

            if (!Guid.TryParse(userIdClaim, out Guid userId))
                return Unauthorized(new { message = "Token inválido: identificador de usuario no válido.", claim = userIdClaim });

            if (userId != id)
                return Forbid();
        }

        _userService.UpdateCareerAndSemester(id, request.Career, request.Semester);
        return Ok(new { message = "Career and semester updated." });
    }
}
