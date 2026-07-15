using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Recommendation.Application.Interfaces;

namespace Recommendation.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/recommendation/[controller]")]
public class RecommendationsController : ControllerBase
{
    private readonly IBookRecommendationService _recommendationService;

    public RecommendationsController(IBookRecommendationService recommendationService)
    {
        _recommendationService = recommendationService;
    }

    private long GetStudentId()
    {
        var studentIdClaim = User.FindFirst("student_id")?.Value
            ?? User.FindFirst("StudentId")?.Value;

        return long.TryParse(studentIdClaim, out var id) ? id : 0;
    }

    /// <summary>Obtiene recomendaciones de libros personalizadas para el estudiante autenticado.</summary>
    /// <param name="limit">Cantidad máxima de recomendaciones (por defecto 10).</param>
    /// <returns>Lista de libros recomendados.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetRecommendations(
        [FromQuery] int limit = 10)
    {
        var studentId = GetStudentId();
        if (studentId == 0)
            return Unauthorized("Student ID not found in token.");

        var books = await _recommendationService.GetRecommendationsAsync(studentId, limit);
        return Ok(books);
    }
}
