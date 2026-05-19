using Microsoft.EntityFrameworkCore;
using Interaction.Domain.Entities;

namespace Interaction.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserFavorite> UserFavorites { get; set; }
    public DbSet<InteractionEvent> InteractionEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // =========================
        // TABLE MAPPINGS
        // =========================
        modelBuilder.Entity<UserFavorite>()
            .ToTable("UserFavorites");

        modelBuilder.Entity<InteractionEvent>()
            .ToTable("InteractionEvents");

        // =========================
        // CONSTRAINTS & INDEXES
        // =========================
        
        // A user can only favorite a book once
        modelBuilder.Entity<UserFavorite>()
            .HasIndex(uf => new { uf.UserId, uf.BookId })
            .IsUnique();

        // Save enum as string in DB
        modelBuilder.Entity<InteractionEvent>()
            .Property(ie => ie.Type)
            .HasConversion<string>();

        // Index for faster queries on user history
        modelBuilder.Entity<InteractionEvent>()
            .HasIndex(ie => ie.UserId);

        modelBuilder.Entity<InteractionEvent>()
            .HasIndex(ie => ie.BookId);
    }
}
