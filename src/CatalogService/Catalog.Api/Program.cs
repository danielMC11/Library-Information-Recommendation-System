using Catalog.Application.Interfaces;
using Catalog.Application.Services;
using Catalog.Infrastructure.Persistence;
using Catalog.Infrastructure.Repositories;
using Catalog.Api.Config;
using Catalog.Api.Messaging;
using Catalog.Domain.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Text;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

var builder = WebApplication.CreateBuilder(args);

//CORSHOTFIX
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


// -------------------- DATABASE   
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Catalog.Infrastructure")
    )
);


// -------------------- DEPENDENCIES --------------------


builder.Services.Configure<RabbitMQSettings>(
    builder.Configuration.GetSection(RabbitMQSettings.SectionName)
);



builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<UploadBooksService>();
builder.Services.AddScoped<BookService>();
builder.Services.AddSingleton<CatalogUploadPublisher>();
builder.Services.AddSingleton<BookInteractionPublisher>();



// -------------------- JWT CONFIG --------------------
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

// -------------------- APP --------------------
var app = builder.Build();

// -------------------- DATABASE MIGRATION --------------------
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await dbContext.Database.MigrateAsync();
}

// -------------------- PIPELINE --------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//CORSHOTFIX
app.UseCors("AllowLocalhost5173");
app.UseHttpsRedirection();

app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllers();

await app.RunAsync();

static async Task SeedCatalogDataAsync(AppDbContext dbContext)
{
    if (await dbContext.Books.AnyAsync())
        return;

    var book1 = new Book
    {
        Title = "Clean Code",
        Isbn = "9780132350884",
        Classification = "Programming",
        Language = "English",
        Year = "2008",
        Summary = "A Handbook of Agile Software Craftsmanship."
    };
    book1.Authors.Add(new Author { Name = "Robert C. Martin" });
    book1.Topics.Add(new Topic { Name = "Software Engineering" });

    var book2 = new Book
    {
        Title = "Domain-Driven Design",
        Isbn = "9780321125217",
        Classification = "Programming",
        Language = "English",
        Year = "2003",
        Summary = "Tackling Complexity in the Heart of Software."
    };
    book2.Authors.Add(new Author { Name = "Eric Evans" });
    book2.Topics.Add(new Topic { Name = "Domain Modeling" });

    dbContext.Books.AddRange(book1, book2);
    await dbContext.SaveChangesAsync();
}