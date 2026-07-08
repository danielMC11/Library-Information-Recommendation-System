using Shared.DTOs;
using Interaction.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Interaction.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentFavoriteController : ControllerBase
{
    private readonly IStudentFavoriteService _favoriteService;

    public StudentFavoriteController(IStudentFavoriteService favoriteService)
    {
        _favoriteService = favoriteService;
    }

    private long GetStudentId()
    {
        var studentIdClaim = User.FindFirst("student_id")?.Value
            ?? User.FindFirst("StudentId")?.Value;

        return long.TryParse(studentIdClaim, out var id) ? id : 0;
    }

    [Authorize]
    [HttpPost("save/{bookId:guid}")]
    public async Task<ActionResult<StudentFavoriteDto>> SaveFavorite([FromRoute] Guid bookId)
    {
        var studentId = GetStudentId();

        if (studentId == 0)
            return Unauthorized("Token inválido.");

        try
        {
            var result = await _favoriteService.SaveFavoriteAsync(studentId, bookId);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize]
    [HttpGet("list")]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetFavorites()
    {
        var studentId = GetStudentId();

        if (studentId == 0)
            return Unauthorized("Token inválido.");

        try
        {
            var books = await _favoriteService.GetStudentFavoritesAsync(studentId);
            return Ok(books);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize]
    [HttpGet("check/{bookId:guid}")]
    public async Task<ActionResult<bool>> CheckFavorite([FromRoute] Guid bookId)
    {
        var studentId = GetStudentId();

        if (studentId == 0)
            return Unauthorized("Token inválido.");

        try
        {
            var result = await _favoriteService.CheckFavoriteAsync(studentId, bookId);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize]
    [HttpDelete("delete/{bookId:guid}")]
    public async Task<IActionResult> DeleteFavorite([FromRoute] Guid bookId)
    {
        var studentId = GetStudentId();

        if (studentId == 0)
            return Unauthorized("Token inválido.");

        try
        {
            await _favoriteService.DeleteFavoriteAsync(studentId, bookId);
            return NoContent();
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}