using Catalog.Api.Enums;
using Catalog.Application.Events;
using Catalog.Api.Messaging;
using Catalog.Application.Interfaces;
using Catalog.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Catalog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;
    private readonly BookInteractionPublisher _publisher;

    public BooksController(IBookService bookService, BookInteractionPublisher publisher)
    {
        _bookService = bookService;
        _publisher = publisher;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDetailsDto>>> GetBooks([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var books = await _bookService.GetBooksPagedAsync(page, pageSize);
        return Ok(books);
    }

    [Authorize]
    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<BookDetailsDto>>> SearchBooks([FromQuery] string name)
    {

        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
        ?? User.FindFirst("sub")?.Value
        ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrWhiteSpace(name))
            return BadRequest("El término de búsqueda no puede estar vacío.");

        var books = await _bookService.SearchBooksAsync(name);

        await _publisher.PublishUserInteractionAsync(new UserInteractionEvent
        {
            BookIds = books.Select(b => b.Id).ToList(),
            UserId = Guid.Parse(userIdClaim),
            InteractionType = InteractionType.SEARCH.ToString()
        });

        return Ok(books);
    }

    [Authorize]
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetBookDetailsAsync(Guid id)
    {

        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
        ?? User.FindFirst("sub")?.Value
        ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        if (id == Guid.Empty)
            return BadRequest("El Id proporcionado no es válido.");

        var book = await _bookService.GetBookDetailsAsync(id);

        if (book is null)
            return NotFound($"No se encontró el libro con Id: {id}");

            await _publisher.PublishUserInteractionAsync(new UserInteractionEvent
            {
                BookIds = new List<Guid> { book.Id },
                UserId =  Guid.Parse(userIdClaim), 
                InteractionType = InteractionType.VIEW.ToString()
             });

            return Ok(book);
        
    }

    [HttpPost("details")]
    public async Task<ActionResult<IEnumerable<BookDetailsDto>>> GetBooksByIds([FromBody] List<Guid> ids)
    {
        if (ids == null || ids.Count == 0)
            return BadRequest("La lista de ids no puede estar vacía.");

        var books = await _bookService.GetBooksByIdsAsync(ids);
        return Ok(books);
    }

}
