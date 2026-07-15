using Shared.DTOs;
using Catalog.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace Catalog.Api.Controllers;

[ApiController]
[Route("api/catalog/[controller]")]
[Authorize]
public class UploadBooksController : ControllerBase
{
    private readonly IUploadBooksService _uploadService;

    public UploadBooksController(IUploadBooksService uploadService)
    {
        _uploadService = uploadService;
    }

    private static readonly string[] _allowedExtensions = [".marc", ".iso2709"];

    /// <summary>Sube y procesa un archivo ISO 2709 para importar libros al catálogo.</summary>
    /// <param name="file">Archivo ISO 2709 a procesar (extensiones permitidas: .marc, .iso2709).</param>
    /// <returns>Métricas del procesamiento (cantidad de libros importados, etc.).</returns>
    [HttpPost("upload")]
    public async Task<ActionResult<UploadResponseDto>> UploadIsoFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("Archivo inválido.");

        var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
        if (!_allowedExtensions.Contains(extension))
            return BadRequest($"Formato no permitido. Extensiones aceptadas: {string.Join(", ", _allowedExtensions)}.");

        using var stream = new MemoryStream();
        await file.CopyToAsync(stream);

        var metrics = await _uploadService.ProcessIso2709Async(stream.ToArray());

        return Ok(metrics);
    }
}
