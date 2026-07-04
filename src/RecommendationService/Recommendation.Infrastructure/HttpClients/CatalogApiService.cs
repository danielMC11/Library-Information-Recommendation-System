using System.Net.Http.Json;
using Shared.DTOs;
using Recommendation.Application.Interfaces;

namespace Recommendation.Infrastructure.HttpClients;

public class CatalogApiService : ICatalogApiService
{
    private readonly HttpClient _httpClient;

    public CatalogApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<BookDto>> GetBooksByIdsAsync(List<Guid> ids)
    {
        var response = await _httpClient.PostAsJsonAsync("api/books/details", ids);

        if (!response.IsSuccessStatusCode)
            return Enumerable.Empty<BookDto>();

        var books = await response.Content.ReadFromJsonAsync<IEnumerable<BookDto>>();
        return books ?? Enumerable.Empty<BookDto>();
    }
}
