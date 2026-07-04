using Google.GenAI;
using Google.GenAI.Types;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class GeminiEmbeddingService
{
    private readonly string _apiKey;
    private readonly ILogger<GeminiEmbeddingService> _logger;

    public GeminiEmbeddingService(IConfiguration config, ILogger<GeminiEmbeddingService> logger)
    {
        _apiKey = config["Gemini:ApiKey"];
        _logger = logger;
    }

    public async Task<float[]> GenerateEmbeddingAsync(string text)
    {
        var client = new Client(apiKey: _apiKey);
        var config = new EmbedContentConfig { OutputDimensionality = 768 };

        var response = await client.Models.EmbedContentAsync(
            model: "gemini-embedding-001",
            contents: new List<Content>
            {
                new Content { Parts = new List<Part> { new Part { Text = text } } }
            },
            config: config
        );

        if (response.Embeddings == null || response.Embeddings.Count == 0)
            throw new InvalidOperationException("No se obtuvieron embeddings.");

        var result = response.Embeddings[0].Values.Select(v => (float)v).ToArray();

        _logger.LogInformation("Embedding generado, dimensiones: {Dimensiones}", result.Length);

        return result;
    }
}