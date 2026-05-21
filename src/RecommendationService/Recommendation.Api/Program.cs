using Microsoft.VisualBasic;
using Recommendation.Api.Config;
using Recommendation.Api.Messaging;
using Recommendation.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.Configure<RabbitMQSettings>(
    builder.Configuration.GetSection(RabbitMQSettings.SectionName)
);


builder.Services.AddScoped<Recommendation.Application.Interfaces.IVectorRepository, Recommendation.Infrastructure.Repositories.QdrantVectorRepository>();

builder.Services.AddScoped<GeminiEmbeddingService>();
builder.Services.AddScoped<QdrantService>();
builder.Services.AddScoped<ProcessBooksBatchService>();

// RabbitMQConfig primero: crea el exchange/queue/binding al arrancar
builder.Services.AddHostedService<RabbitMQConfig>();
// Listener: se registra después para que el binding ya exista
builder.Services.AddHostedService<RecommendationEmbeddingListener>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
