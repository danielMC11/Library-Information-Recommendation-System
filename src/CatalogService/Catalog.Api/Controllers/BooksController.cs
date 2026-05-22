using Catalog.Api.DTOs;
using Catalog.Api.Enums;
using Catalog.Application.Events;
using Catalog.Api.Messaging;
using Catalog.Application.Services;
using Catalog.Domain.Entities;
using Catalog.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;


namespace Catalog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly BookService _bookService;
    private readonly BookInteractionPublisher _publisher;


    public BooksController(AppDbContext context, BookService bookService, BookInteractionPublisher publisher)
    {
        _bookService = bookService;
        _context = context;
        _publisher = publisher;
    }

    // GET: api/books?page=1&pageSize=10
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetBooks([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var books = await _context.Books
            .Include(b => b.Authors)
            .Include(b => b.Topics)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(b => new BookDto
            {
                Id = b.Id,
                Isbn = b.Isbn,
                Title = b.Title,
                Classification = b.Classification,
                Language = b.Language,
                Year = b.Year,
                Summary = b.Summary,
                Authors = b.Authors.Select(a => a.Name).ToList(),
                Topics = b.Topics.Select(t => t.Name).ToList()
            })
            .ToListAsync();

        return Ok(books);
    }

    // GET: api/books/search?name=palabra
    [Authorize]
    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<BookDto>>> SearchBooks([FromQuery] string name)
    {

        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
        ?? User.FindFirst("sub")?.Value
        ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;


        if (string.IsNullOrWhiteSpace(name))
            return BadRequest("El término de búsqueda no puede estar vacío.");

        var books = await _context.Books
            .Include(b => b.Authors)
            .Include(b => b.Topics)
            // Se usa Contains para una búsqueda parcial (tipo LIKE en SQL)
            .Where(b => b.Title.Contains(name))
            .Take(50) // Limitamos a 50 resultados para evitar sobrecargas
            .Select(b => new BookDto
            {
                Id = b.Id,
                Isbn = b.Isbn,
                Title = b.Title,
                Classification = b.Classification,
                Language = b.Language,
                Year = b.Year,
                Summary = b.Summary,
                Authors = b.Authors.Select(a => a.Name).ToList(),
                Topics = b.Topics.Select(t => t.Name).ToList()
            })
            .ToListAsync();


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


    // POST: api/books/details
    [HttpPost("details")]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetBooksByIds([FromBody] List<Guid> ids)
    {
        if (ids == null || ids.Count == 0)
            return BadRequest("La lista de ids no puede estar vacía.");

        var books = await _context.Books
            .Where(b => ids.Contains(b.Id))
            .Include(b => b.Authors)
            .Include(b => b.Topics)
            .Select(b => new BookDto
            {
                Id = b.Id,
                Isbn = b.Isbn,
                Title = b.Title,
                Classification = b.Classification,
                Language = b.Language,
                Year = b.Year,
                Summary = b.Summary,
                Authors = b.Authors.Select(a => a.Name).ToList(),
                Topics = b.Topics.Select(t => t.Name).ToList()
            })
            .ToListAsync();

        return Ok(books);
    }




}