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

    private Guid GetUserId()
    {
        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
            ?? User.FindFirst("sub")?.Value
            ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        return Guid.Parse(userIdClaim!);
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

        var userId = GetUserId();
        var books = await _bookService.SearchBooksAsync(name, userId);

        return Ok(books);
    }

    [Authorize]
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetBookDetailsAsync(Guid id)
    {
        if (id == Guid.Empty)
            return BadRequest("El Id proporcionado no es válido.");

        var userId = GetUserId();
        var book = await _bookService.GetBookDetailsAsync(id, userId);

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
