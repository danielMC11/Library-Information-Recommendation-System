using Microsoft.EntityFrameworkCore;

namespace Recommendation.Infrastructure.Persistence;

public class RecommendationDbContext : DbContext
{
    public RecommendationDbContext(DbContextOptions<RecommendationDbContext> options) : base(options)
    {
    }

    public DbSet<SystemConfigEntry> SystemConfig { get; set; } = null!;
    public DbSet<RateLimitState> RateLimitStates { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SystemConfigEntry>(entity =>
        {
            entity.ToTable("SystemConfig");
            entity.HasIndex(e => e.Key).IsUnique();
        });

        modelBuilder.Entity<RateLimitState>(entity =>
        {
            entity.ToTable("RateLimitStates");
            entity.HasIndex(e => new { e.MinuteStart, e.Date }).IsUnique();
        });
    }
}
