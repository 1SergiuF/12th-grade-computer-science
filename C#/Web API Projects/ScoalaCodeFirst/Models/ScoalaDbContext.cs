using Microsoft.EntityFrameworkCore;

namespace ScoalaCodeFirst.Models
{
    public class ScoalaDbContext : DbContext
    {
        public ScoalaDbContext(DbContextOptions<ScoalaDbContext> options) : base(options) { }

        public DbSet<Elev> elevi {  get; set; }
    }
}
