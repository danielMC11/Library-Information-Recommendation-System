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

    [Authorize(Roles = "Admin")]
    [HttpPatch("{id:guid}/activate")]
    public IActionResult Activate(Guid id)
    {
        _userService.Activate(id);
        return Ok(new { message = "User activated." });
    }

    [Authorize(Roles = "Admin")]
    [HttpPatch("{id:guid}/deactivate")]
    public IActionResult Deactivate(Guid id)
    {
        _userService.Deactivate(id);
        return Ok(new { message = "User deactivated." });
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("{id:guid}/roles")]
    public IActionResult AssignRole(Guid id, [FromBody] AssignRoleRequest request)
    {
        _userService.AssignRole(id, request.RoleName);
        return Ok(new { message = "Role assigned." });
    }

    [Authorize]
    [HttpPatch("{id:guid}/career-semester")]
    public IActionResult UpdateCareerAndSemester(Guid id, [FromBody] UpdateCareerAndSemesterRequest request)
    {
        // Intenta obtener la claim "sub" de diferentes formas
        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value 
            ?? User.FindFirst("sub")?.Value 
            ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        var isAdmin = User.IsInRole("Admin");

        // Si no es admin, verifica que sea el propietario
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