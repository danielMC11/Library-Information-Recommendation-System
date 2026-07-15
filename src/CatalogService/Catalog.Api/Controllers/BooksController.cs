using Shared.DTOs;
using Catalog.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Catalog.Api.Controllers;

[ApiController]
[Route("api/catalog/[controller]")]
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

    /// <summary>Obtiene libros paginados. Endpoint público.</summary>
    /// <param name="page">Número de página (por defecto 1).</param>
    /// <param name="pageSize">Tamaño de página (por defecto 10).</param>
    /// <returns>Lista paginada de libros.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetBooks([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var books = await _bookService.GetBooksPagedAsync(page, pageSize);
        return Ok(books);
    }

    /// <summary>Busca libros por nombre. Requiere autenticación.</summary>
    /// <param name="name">Término de búsqueda.</param>
    /// <returns>Lista de libros que coinciden con el término.</returns>
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

    /// <summary>Obtiene el detalle de un libro por su ID. Requiere autenticación.</summary>
    /// <param name="id">ID del libro (GUID).</param>
    /// <returns>Detalle del libro incluyendo información de interacción del estudiante.</returns>
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

    /// <summary>Obtiene múltiples libros por sus IDs. Endpoint público.</summary>
    /// <param name="ids">Lista de GUIDs de libros.</param>
    /// <returns>Lista de libros encontrados.</returns>
    [HttpPost("details")]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetBooksByIds([FromBody] List<Guid> ids)
    {
        if (ids == null || ids.Count == 0)
            return BadRequest("La lista de ids no puede estar vacía.");

        var books = await _bookService.GetBooksByIdsAsync(ids);
        return Ok(books);
    }

}
