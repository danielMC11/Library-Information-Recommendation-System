using Shared.Events;
using Catalog.Application.Interfaces;
using System.Net.Http.Json;



namespace Catalog.Infrastructure.HttpClients;

public class InteractionApiService : IInteractionApiService
{
    private readonly HttpClient _httpClient;


    public InteractionApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task SendStudentInteractionAsync(StudentInteractionEvent interactionEvent)
    {
        var response = await _httpClient.PostAsJsonAsync("api/interaction/StudentInteractions", interactionEvent);
        response.EnsureSuccessStatusCode();
    }
}