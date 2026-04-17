using Microsoft.EntityFrameworkCore;
using Catalog.Domain.Entities;

namespace Catalog.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Topic> Topics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // =========================
        // TABLE MAPPINGS
        // =========================
        modelBuilder.Entity<Book>()
            .ToTable("Books");

        modelBuilder.Entity<Author>()
            .ToTable("Authors");

        modelBuilder.Entity<Topic>()
            .ToTable("Topics");

        // =========================
        // RELATION: BOOK - AUTHOR (MANY TO MANY)
        // =========================
        modelBuilder.Entity<Book>()
            .HasMany(b => b.Authors)
            .WithMany(a => a.Books)
            .UsingEntity(j => j.ToTable("AuthorBook"));

        // =========================
        // RELATION: BOOK - TOPIC (MANY TO MANY)
        // =========================
        modelBuilder.Entity<Book>()
            .HasMany(b => b.Topics)
            .WithMany(t => t.Books)
            .UsingEntity(j => j.ToTable("BookTopic"));

        // =========================
        // OPTIONAL CONSTRAINTS
        // =========================
        modelBuilder.Entity<Author>()
            .HasIndex(a => a.Name)
            .IsUnique();

        modelBuilder.Entity<Topic>()
            .HasIndex(t => t.Name)
            .IsUnique();
    }
}