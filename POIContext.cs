using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class POIContext : DbContext
    {
        public POIContext(DbContextOptions<POIContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<POI> POIs { get; set; }
    }
}
