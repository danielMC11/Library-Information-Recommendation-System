namespace Recommendation.Application.Interfaces;

public interface IGeminiEmbeddingService
{
    Task<float[]> GenerateEmbeddingAsync(string text);
}
