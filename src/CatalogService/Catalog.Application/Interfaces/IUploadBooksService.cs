using Shared.DTOs;

namespace Catalog.Application.Interfaces;

public interface IUploadBooksService
{
    Task<UploadResponseDto> ProcessIso2709Async(byte[] fileBytes);
}
