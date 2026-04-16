using Catalog.Application.DTOs;
using Catalog.Application.Services;
using Microsoft.AspNetCore.Mvc;


namespace Catalog.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UploadBooksController : ControllerBase
{


    private readonly UploadBooksService _uploadService;

    public UploadBooksController(UploadBooksService uploadService)
    {
        _uploadService = uploadService;
    }


    [HttpPost("upload")]
    public async Task<ActionResult<UploadResponseDto>> UploadIsoFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("Archivo inválido.");

        using var stream = new MemoryStream();
        await file.CopyToAsync(stream);

        // Asumiendo que ajustaste ProcessIso2709Async para retornar estos datos
        var result = await _uploadService.ProcessIso2709Async(stream.ToArray());

        return Ok(result);
    }



}

