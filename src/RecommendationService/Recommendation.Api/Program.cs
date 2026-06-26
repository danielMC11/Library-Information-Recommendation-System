using DotNetEnv;
using Microsoft.VisualBasic;
using Shared.Config;
using Recommendation.Api.Messaging;
using Recommendation.Application.Services;
using Recommendation.Infrastructure.Messaging;
using Recommendation.Infrastructure.Messaging.Config;

Env.Load(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".env"));

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

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
builder.Services.AddScoped<CalculateUserProfileVectorService>();

// RabbitMQConfig primero: crea el exchange/queue/binding al arrancar
builder.Services.AddHostedService<RabbitMQConfig>();
// Listener: se registra después para que el binding ya exista
builder.Services.AddHostedService<BooksUploadedListener>();
builder.Services.AddHostedService<StudentInteractionsAccumulatedListener>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
