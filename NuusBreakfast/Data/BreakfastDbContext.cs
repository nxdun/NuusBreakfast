using Microsoft.EntityFrameworkCore;

public class BreakfastDbContext : DbContext
{
    public BreakfastDbContext(DbContextOptions<BreakfastDbContext> options) : base(options)
    {
    }

    public DbSet<Breakfast> Breakfasts { get; set; }
}