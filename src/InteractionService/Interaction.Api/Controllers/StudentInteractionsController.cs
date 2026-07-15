using Shared.Events;
using Interaction.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Interaction.Api.Controllers;

[ApiController]
[Route("api/interaction/[controller]")]
public class StudentInteractionsController : ControllerBase
{
    private readonly IStudentInteractionService _studentInteractionService;

    public StudentInteractionsController(IStudentInteractionService studentInteractionService)
    {
        _studentInteractionService = studentInteractionService;
    }

    /// <summary>Guarda una interacción de un estudiante con uno o más libros.</summary>
    /// <param name="interactionEvent">Datos de la interacción (StudentId, Interaction.BookIds, Interaction.InteractionType: SEARCH, VIEW, FAVORITE, UNFAVORITE).</param>
    /// <returns>Código 200 si se procesó correctamente.</returns>
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
