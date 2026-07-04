using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Recommendation.Application.Services;

namespace Recommendation.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class RecommendationsController : ControllerBase
{
    private readonly BookRecommendationService _recommendationService;

    public RecommendationsController(BookRecommendationService recommendationService)
    {
        _recommendationService = recommendationService;
    }

    private long GetStudentId()
    {
        var studentIdClaim = User.FindFirst("student_id")?.Value
            ?? User.FindFirst("StudentId")?.Value;

        return long.TryParse(studentIdClaim, out var id) ? id : 0;
    }

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
