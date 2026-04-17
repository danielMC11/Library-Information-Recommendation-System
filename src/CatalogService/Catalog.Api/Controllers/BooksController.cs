using Catalog.Api.DTOs;
using Catalog.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly AppDbContext _context;

    public BooksController(AppDbContext context)
    {
        _context = context;
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
    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<BookDto>>> SearchBooks([FromQuery] string name)
    {
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

        return Ok(books);
    }
}