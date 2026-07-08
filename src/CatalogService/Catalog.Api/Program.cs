using Catalog.Application.Interfaces;
using Catalog.Application.Services;
using Catalog.Domain.Entities;
using Catalog.Infrastructure.HttpClients;
using Catalog.Infrastructure.Messaging;
using Catalog.Infrastructure.Messaging.Config;
using Catalog.Infrastructure.Persistence;
using Catalog.Infrastructure.Repositories;
using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Shared.Config;
using System.Text;

// -------------------- ENVIRONMENT VARIABLES --------------------
Env.Load(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".env"));
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

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
        Title = "Catalog API",
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
        b => b.MigrationsAssembly("Catalog.Infrastructure")
    )
);

// -------------------- CONFIGURATION --------------------
builder.Services.Configure<RabbitMQSettings>(
    builder.Configuration.GetSection(RabbitMQSettings.SectionName));

// -------------------- DEPENDENCIES --------------------
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IUploadBooksService, UploadBooksService>();
builder.Services.AddSingleton<IBookUploadedPublisher, BookUploadedPublisher>();

// -------------------- MESSAGING --------------------
builder.Services.AddHostedService<RabbitMQConfig>();

// -------------------- HTTP CLIENTS --------------------
builder.Services.AddHttpClient<IInteractionApiService, InteractionApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["InteractionApi:BaseUrl"] ?? "http://localhost:5144");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    client.Timeout = TimeSpan.FromSeconds(30);
});

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
await app.RunAsync();
