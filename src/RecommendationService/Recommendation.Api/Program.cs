using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Recommendation.Application.Interfaces;
using Recommendation.Application.Services;
using Recommendation.Infrastructure.HttpClients;
using Recommendation.Infrastructure.Messaging;
using Recommendation.Infrastructure.Messaging.Config;
using Recommendation.Infrastructure.Persistence;
using Recommendation.Infrastructure.Services;
using Shared.Config;
using System.Text;

// -------------------- ENVIRONMENT VARIABLES --------------------
Env.Load(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".env"));

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();

// -------------------- CONTROLLERS --------------------
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// -------------------- SWAGGER --------------------
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Recommendation API",
        Version = "v1"
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid JWT token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });

    options.AddSecurityRequirement(document => new()
    {
        [new OpenApiSecuritySchemeReference("Bearer", document)] = []
    });
});

// -------------------- DATABASE --------------------
builder.Services.AddDbContext<RecommendationDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("RecommendationDb"),
        b => b.MigrationsAssembly("Recommendation.Infrastructure")
    )
);

// -------------------- CONFIGURATION --------------------
builder.Services.Configure<RabbitMQSettings>(
    builder.Configuration.GetSection(RabbitMQSettings.SectionName));

builder.Services.Configure<RateLimitSettings>(
    builder.Configuration.GetSection(RateLimitSettings.SectionName));

builder.Services.Configure<StudentVectorSettings>(
    builder.Configuration.GetSection(StudentVectorSettings.SectionName));

// -------------------- DEPENDENCIES --------------------
builder.Services.AddScoped<IVectorRepository, Recommendation.Infrastructure.Repositories.QdrantVectorRepository>();
builder.Services.AddScoped<IGeminiEmbeddingService, GeminiEmbeddingService>();
builder.Services.AddScoped<IQdrantService, QdrantService>();
builder.Services.AddScoped<IBookVectorService, BookVectorService>();
builder.Services.AddScoped<IStudentProfileVectorService, StudentProfileVectorService>();
builder.Services.AddScoped<IBookRecommendationService, BookRecommendationService>();
builder.Services.AddScoped<IRateLimitTracker, RateLimitTracker>();

// -------------------- HTTP CLIENTS --------------------
builder.Services.AddHttpClient<ICatalogApiService, CatalogApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["CatalogService:Url"]);
});

// -------------------- MESSAGING --------------------
builder.Services.AddHostedService<RabbitMQConfig>();
builder.Services.AddHostedService<BookUploadedListener>();
builder.Services.AddHostedService<StudentRegisteredListener>();
builder.Services.AddHostedService<StudentInteractionsAccumulatedListener>();

// -------------------- AUTHENTICATION --------------------
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

// -------------------- AUTHORIZATION --------------------
builder.Services.AddAuthorization();

// -------------------- BUILD --------------------
var app = builder.Build();

// -------------------- DATABASE MIGRATION --------------------
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<RecommendationDbContext>();
    await dbContext.Database.MigrateAsync();
}

// -------------------- PIPELINE --------------------
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

// -------------------- RUN --------------------
app.Run();
