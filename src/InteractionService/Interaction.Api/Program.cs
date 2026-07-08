using DotNetEnv;
using Interaction.Application.Interfaces;
using Interaction.Application.Services;
using Interaction.Infrastructure.HttpClients;
using Interaction.Infrastructure.Messaging;
using Interaction.Infrastructure.Messaging.Config;
using Interaction.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Shared.Config;
using System.Text;

// -------------------- ENVIRONMENT VARIABLES --------------------
Env.Load(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".env"));

var builder = WebApplication.CreateBuilder(args);

// -------------------- CORS --------------------
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost5173", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    });
});

// -------------------- CONTROLLERS --------------------
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// -------------------- SWAGGER --------------------
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Interaction API",
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
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Interaction.Infrastructure")
    )
);

// -------------------- CONFIGURATION --------------------
builder.Services.Configure<RabbitMQSettings>(
    builder.Configuration.GetSection(RabbitMQSettings.SectionName));

builder.Services.Configure<InteractionAccumulationSettings>(
    builder.Configuration.GetSection(InteractionAccumulationSettings.SectionName));

// -------------------- DEPENDENCIES --------------------
builder.Services.AddScoped<IStudentFavoriteRepository, Interaction.Infrastructure.Repositories.StudentFavoriteRepository>();
builder.Services.AddScoped<IStudentFavoriteService, StudentFavoriteService>();
builder.Services.AddScoped<IStudentInteractionRepository, Interaction.Infrastructure.Repositories.StudentInteractionRepository>();
builder.Services.AddScoped<IStudentInteractionService, StudentInteractionService>();
builder.Services.AddSingleton<IStudentInteractionsAccumulatedPublisher, StudentInteractionsAccumulatedPublisher>();

// -------------------- HTTP CLIENTS --------------------
builder.Services.AddHttpClient<ICatalogApiService, CatalogApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["CatalogApi:BaseUrl"] ?? "http://localhost:5281");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    client.Timeout = TimeSpan.FromSeconds(30);
});

// -------------------- MESSAGING --------------------
builder.Services.AddHostedService<RabbitMQConfig>();

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
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await dbContext.Database.MigrateAsync();
}

// -------------------- PIPELINE --------------------
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowLocalhost5173");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

// -------------------- RUN --------------------
app.Run();
