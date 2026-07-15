using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Auth.Application.Interfaces;
using System.Security.Claims;

namespace Auth.Api.Controllers;

[ApiController]
[Route("api/auth/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IUserService _userService;

    public StudentController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>Obtiene todos los estudiantes. Solo accesible para administradores.</summary>
    /// <returns>Lista de estudiantes.</returns>
    [Authorize(Roles = "ADMIN")]
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetAllStudents());
    }

    /// <summary>Obtiene un estudiante por su ID.</summary>
    /// <param name="id">ID del estudiante.</param>
    /// <returns>Datos del estudiante. Los estudiantes solo pueden ver su propio perfil.</returns>
    [Authorize]
    [HttpGet("{id:long}")]
    public IActionResult GetById(long id)
    {
        var role = User.FindFirst(ClaimTypes.Role)?.Value;
        var studentIdClaim = User.FindFirst("student_id")?.Value;

        if (role != "ADMIN" && (studentIdClaim is null || studentIdClaim != id.ToString()))
            return Forbid();

        var student = _userService.GetStudentById(id);
        return student is null ? NotFound() : Ok(student);
    }
}
