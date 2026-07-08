using Shared.Events;
using Interaction.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Interaction.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentInteractionsController : ControllerBase
{
    private readonly IStudentInteractionService _studentInteractionService;

    public StudentInteractionsController(IStudentInteractionService studentInteractionService)
    {
        _studentInteractionService = studentInteractionService;
    }

    [HttpPost]
    public async Task<IActionResult> SaveInteraction([FromBody] StudentInteractionEvent interactionEvent)
    {
        try
        {
            await _studentInteractionService.ExecuteAsync(interactionEvent);
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
