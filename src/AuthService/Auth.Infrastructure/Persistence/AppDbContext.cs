using Microsoft.EntityFrameworkCore;
using Auth.Domain.Entities;

namespace Auth.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Career> Careers => Set<Career>();
    public DbSet<Subject> Subjects => Set<Subject>();
    public DbSet<CareerSubject> CareerSubjects => Set<CareerSubject>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // =========================
        // TABLE MAPPINGS
        // =========================
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Student>().ToTable("Students");
        modelBuilder.Entity<Career>().ToTable("Careers");
        modelBuilder.Entity<Subject>().ToTable("Subjects");
        modelBuilder.Entity<CareerSubject>().ToTable("CareerSubjects");

        // =========================
        // USER
        // =========================
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        // Credential — owned type, mapeado como columnas en Users
        modelBuilder.Entity<User>().OwnsOne(u => u.Credential, cb =>
        {
            cb.Property(c => c.PasswordHash)
                .HasColumnName("PasswordHash")
                .HasMaxLength(512);

            cb.Property(c => c.Salt)
                .HasColumnName("Salt")
                .HasMaxLength(128);

            cb.Property(c => c.LastChangedAt)
                .HasColumnName("CredentialLastChangedAt");
        });

        // Role guardado como string en DB
        modelBuilder.Entity<User>()
            .Property(u => u.Role)
            .HasConversion<string>();

        // =========================
        // USER <-> STUDENT (one-to-one)
        // =========================
        modelBuilder.Entity<User>()
            .HasOne(u => u.Student)
            .WithOne(s => s.User)
            .HasForeignKey<Student>("UserId");

        // =========================
        // CAREER
        // =========================
        modelBuilder.Entity<Career>()
            .HasIndex(c => c.CareerName)
            .IsUnique();

        // =========================
        // STUDENT <-> SUBJECT (many-to-many)
        // =========================
        modelBuilder.Entity<Student>()
            .HasMany(s => s.Subjects)
            .WithMany()
            .UsingEntity(j => j.ToTable("StudentSubjects"));

        // =========================
        // SEED DATA
        // =========================
        SeedData.Seed(modelBuilder);
    }
}
