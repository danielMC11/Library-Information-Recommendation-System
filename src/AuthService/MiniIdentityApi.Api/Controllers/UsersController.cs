using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

    [Authorize(Roles = "ADMIN")]
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
}