using Microsoft.AspNetCore.Mvc;

namespace Recommendation.Api.Controllers;

public class TextoRequest
{
    public string Texto { get; set; } = string.Empty;
}

[ApiController]
[Route("api/[controller]")]
public class TestEmbeddingsController : ControllerBase
{
    private readonly GeminiEmbeddingService _embeddingService;

    // Inyectamos tu servicio a través del constructor
    public TestEmbeddingsController(GeminiEmbeddingService embeddingService)
    {
        _embeddingService = embeddingService;
    }

    [HttpPost("generar")]
    public async Task<IActionResult> GenerarEmbeddings([FromBody] TextoRequest peticion)
    {
        // Validamos que el usuario haya enviado un texto
        if (peticion == null || string.IsNullOrWhiteSpace(peticion.Texto))
        {
            return BadRequest(new { mensaje = "Debes enviar un texto válido." });
        }

        try
        {
            var vector = await _embeddingService.GenerateEmbeddingAsync(peticion.Texto);

            return Ok(new
            {
                DimensionesPorVector = vector.Length,
                Resultado = vector
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { mensaje = "Ocurrió un error al generar el vector.", error = ex.Message });
        }
    }

}