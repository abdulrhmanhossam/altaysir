using Core.Entities;

namespace Infrastructure.Data;

public class AltaysirContext : DbContext
{
    public AltaysirContext(DbContextOptions<AltaysirContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}
