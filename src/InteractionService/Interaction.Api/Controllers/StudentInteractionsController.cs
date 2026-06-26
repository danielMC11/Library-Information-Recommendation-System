using Shared.Events;
using Interaction.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Interaction.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentInteractionsController : ControllerBase
{
    private readonly StudentInteractionService _studentInteractionService;

    public StudentInteractionsController(StudentInteractionService studentInteractionService)
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
