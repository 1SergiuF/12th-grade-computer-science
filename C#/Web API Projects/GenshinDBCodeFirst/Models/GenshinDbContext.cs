using Microsoft.EntityFrameworkCore;

namespace GenshinDBCodeFirst.Models
{
    public class GenshinDbContext : DbContext
    {
        public GenshinDbContext(DbContextOptions<GenshinDbContext> options) : base(options) { }

        public DbSet<Character> characters { get; set; }
    }
}
