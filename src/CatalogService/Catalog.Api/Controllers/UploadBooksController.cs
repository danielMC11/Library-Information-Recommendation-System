using Catalog.Application.DTOs;
using Catalog.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Catalog.Api.Messaging;
using Catalog.Application.Events;

namespace Catalog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class UploadBooksController : ControllerBase
{
    private readonly UploadBooksService _uploadService;
    private readonly CatalogUploadPublisher _publisher;

    public UploadBooksController(UploadBooksService uploadService, CatalogUploadPublisher publisher)
    {
        _uploadService = uploadService;
        _publisher = publisher;
    }

    [HttpPost("upload")]
    public async Task<ActionResult<UploadResponseDto>> UploadIsoFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("Archivo inválido.");

        using var stream = new MemoryStream();
        await file.CopyToAsync(stream);

        var (metrics, loadedBooks) = await _uploadService.ProcessIso2709Async(stream.ToArray());

        if (loadedBooks.Any())
        {
            var newBookEvent = new NewBookBatchEvent
            {
                Books = loadedBooks
            };

            await _publisher.PublishNewBookBatchAsync(newBookEvent);
        }

        return Ok(metrics);
    }
}
