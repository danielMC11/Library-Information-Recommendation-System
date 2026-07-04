using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Shared.Config;
using Recommendation.Api.Messaging;
using Recommendation.Application.Interfaces;
using Recommendation.Application.Services;
using Recommendation.Infrastructure.HttpClients;
using Recommendation.Infrastructure.Messaging;
using Recommendation.Infrastructure.Messaging.Config;
using Recommendation.Infrastructure.Persistence;
using Recommendation.Infrastructure.Services;
using System.Text;

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

builder.Services.Configure<RateLimitSettings>(
    builder.Configuration.GetSection(RateLimitSettings.SectionName)
);

builder.Services.Configure<StudentVectorSettings>(
    builder.Configuration.GetSection(StudentVectorSettings.SectionName)
);

builder.Services.AddDbContext<RecommendationDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("RecommendationDb"),
        b => b.MigrationsAssembly("Recommendation.Infrastructure")
    )
);

builder.Services.AddScoped<IVectorRepository, Recommendation.Infrastructure.Repositories.QdrantVectorRepository>();

builder.Services.AddScoped<GeminiEmbeddingService>();
builder.Services.AddScoped<QdrantService>();
builder.Services.AddScoped<BookVectorService>();
builder.Services.AddScoped<StudentProfileVectorService>();
builder.Services.AddScoped<BookRecommendationService>();
builder.Services.AddScoped<RateLimitTracker>();

builder.Services.AddHttpClient<ICatalogApiService, CatalogApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["CatalogService:Url"]);
});

// RabbitMQConfig primero: crea el exchange/queue/binding al arrancar
builder.Services.AddHostedService<RabbitMQConfig>();
// Listener: se registra después para que el binding ya exista
builder.Services.AddHostedService<BookUploadedListener>();
builder.Services.AddHostedService<StudentRegisteredListener>();
builder.Services.AddHostedService<StudentInteractionsAccumulatedListener>();

// JWT Authentication
var jwtKey = builder.Configuration["Jwt:Key"]
    ?? throw new InvalidOperationException("Jwt:Key is missing");

var jwtIssuer = builder.Configuration["Jwt:Issuer"]
    ?? throw new InvalidOperationException("Jwt:Issuer is missing");

var jwtAudience = builder.Configuration["Jwt:Audience"]
    ?? throw new InvalidOperationException("Jwt:Audience is missing");

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtIssuer,
            ValidAudience = jwtAudience,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(jwtKey))
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// Apply EF Core migrations for rate_limit_db
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<RecommendationDbContext>();
    await dbContext.Database.MigrateAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
