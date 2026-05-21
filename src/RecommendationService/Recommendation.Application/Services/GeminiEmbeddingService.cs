using Google.GenAI;
using Google.GenAI.Types;
using System.Reflection.Metadata;

using Microsoft.Extensions.Configuration;


public class GeminiEmbeddingService
{
    private readonly string _apiKey;

    public GeminiEmbeddingService(IConfiguration config)
    {
        _apiKey = config["Gemini:ApiKey"];
    }

    public async Task<float[]> GenerateEmbeddingAsync(string text)
    {
        var client = new Client(apiKey: _apiKey);
        var config = new EmbedContentConfig { OutputDimensionality = 768 };

        var content = new Content
        {
            Parts = new List<Part> { new Part { Text = text } }
        };

        var response = await client.Models.EmbedContentAsync(
            model: "gemini-embedding-001",
            contents: content,
            config: config
        );

        if (response.Embeddings == null || response.Embeddings.Count == 0)
            throw new InvalidOperationException("No se obtuvo embedding para el texto.");

        var vectorArray = response.Embeddings[0].Values.Select(v => (float)v).ToArray();

        Console.WriteLine($"Dimensiones obtenidas: {vectorArray.Length}");

        return vectorArray;
    }

}