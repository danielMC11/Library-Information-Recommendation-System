using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Catalog.Infrastructure.Persistence;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        var connectionString =
            "Host=localhost;Port=5435;Database=catalog_db;Username=postgres;Password=secret-postgres";

        optionsBuilder.UseNpgsql(connectionString);

        return new AppDbContext(optionsBuilder.Options);
    }
}