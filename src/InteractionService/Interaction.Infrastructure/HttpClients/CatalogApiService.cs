using Shared.DTOs;
using Interaction.Application.Interfaces;
using System.Net.Http.Json;

namespace Interaction.Infrastructure.HttpClients;

public class CatalogApiService : ICatalogApiService
{
    private readonly HttpClient _httpClient;


    public CatalogApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<BookDto>> GetBooksByIdsAsync(List<Guid> ids)
    {
        var response = await _httpClient.PostAsJsonAsync("api/catalog/books/details", ids);

        if (!response.IsSuccessStatusCode)
            return Enumerable.Empty<BookDto>();

        var books = await response.Content.ReadFromJsonAsync<IEnumerable<BookDto>>();
        return books ?? Enumerable.Empty<BookDto>();
    }
}
