using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Auth.Application.Interfaces;
using System.Security.Claims;

namespace Auth.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IUserService _userService;

    public StudentController(IUserService userService)
    {
        _userService = userService;
    }

    [Authorize(Roles = "ADMIN")]
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetAllStudents());
    }

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
