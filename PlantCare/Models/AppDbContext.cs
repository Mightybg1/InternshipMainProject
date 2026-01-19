using Microsoft.EntityFrameworkCore;

namespace PlantCare.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plant { get; set; }
    }
}
