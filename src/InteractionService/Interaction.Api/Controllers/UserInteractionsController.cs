using Shared.Events;
using Interaction.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Interaction.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserInteractionsController : ControllerBase
{
    private readonly UserInteractionService _userInteractionService;

    public UserInteractionsController(UserInteractionService userInteractionService)
    {
        _userInteractionService = userInteractionService;
    }

    [HttpPost]
    public async Task<IActionResult> SaveInteraction([FromBody] UserInteractionEvent interactionEvent)
    {
        try
        {
            await _userInteractionService.ExecuteAsync(interactionEvent);
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
