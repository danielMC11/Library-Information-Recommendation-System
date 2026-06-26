using Microsoft.EntityFrameworkCore;
using Interaction.Domain.Entities;

namespace Interaction.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<StudentFavorite> StudentFavorites { get; set; }
    public DbSet<InteractionEvent> InteractionEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // =========================
        // TABLE MAPPINGS
        // =========================
        modelBuilder.Entity<StudentFavorite>()
            .ToTable("StudentFavorites");

        modelBuilder.Entity<InteractionEvent>()
            .ToTable("InteractionEvents");

        // =========================
        // CONSTRAINTS & INDEXES
        // =========================
        
        // A user can only favorite a book once
        modelBuilder.Entity<StudentFavorite>()
            .HasIndex(sf => new { sf.StudentId, sf.BookId })
            .IsUnique();

        // Save enum as string in DB
        modelBuilder.Entity<InteractionEvent>()
            .Property(ie => ie.Type)
            .HasConversion<string>();

        // Index for faster queries on student history
        modelBuilder.Entity<InteractionEvent>()
            .HasIndex(ie => ie.StudentId);

        modelBuilder.Entity<InteractionEvent>()
            .HasIndex(ie => ie.BookId);
    }
}
