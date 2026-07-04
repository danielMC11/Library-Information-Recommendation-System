using Shared.DTOs;
using Catalog.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Catalog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    private long GetStudentId()
    {
        var studentIdClaim = User.FindFirst("student_id")?.Value
            ?? User.FindFirst("StudentId")?.Value;

        return long.TryParse(studentIdClaim, out var id) ? id : 0;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetBooks([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var books = await _bookService.GetBooksPagedAsync(page, pageSize);
        return Ok(books);
    }

    [Authorize]
    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<BookDto>>> SearchBooks([FromQuery] string name)
    {

        if (string.IsNullOrWhiteSpace(name))
            return BadRequest("El término de búsqueda no puede estar vacío.");

        var studentId = GetStudentId();
        var books = await _bookService.SearchBooksAsync(name, studentId);

        return Ok(books);
    }

    [Authorize]
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetBookDetailsAsync(Guid id)
    {
        if (id == Guid.Empty)
            return BadRequest("El Id proporcionado no es válido.");

        var studentId = GetStudentId();
        var book = await _bookService.GetBookDetailsAsync(id, studentId);

        if (book is null)
            return NotFound($"No se encontró el libro con Id: {id}");

        return Ok(book);
    }

    [HttpPost("details")]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetBooksByIds([FromBody] List<Guid> ids)
    {
        if (ids == null || ids.Count == 0)
            return BadRequest("La lista de ids no puede estar vacía.");

        var books = await _bookService.GetBooksByIdsAsync(ids);
        return Ok(books);
    }

}
