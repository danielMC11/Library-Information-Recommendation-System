using Microsoft.AspNetCore.Mvc;

namespace Recommendation.Api.Controller;

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
            // Llamamos a tu método para un solo texto
            var vector = await _embeddingService.GenerateEmbeddingAsync(peticion.Texto);

            // Devolvemos un JSON estructurado para que sea fácil de leer en la respuesta
            return Ok(new
            {
                DimensionesPorVector = vector.Length,
                Resultado = vector
            });
        }
        catch (Exception ex)
        {
            // Capturamos cualquier error (como una API key inválida)
            return StatusCode(500, new { mensaje = "Ocurrió un error al generar el vector.", error = ex.Message });
        }
    }
}