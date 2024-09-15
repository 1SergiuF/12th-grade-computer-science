using Microsoft.EntityFrameworkCore;

namespace SportiviDBOneToMany.Models
{
    public class SportDbContext : DbContext
    {
        public SportDbContext(DbContextOptions<SportDbContext> options) : base(options) { }

        public DbSet<Sport> sporturi { get; set; }
        public DbSet<Sportiv> sportivi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sport>()
                .HasMany(s => s.Sportivi)
                .WithOne(s => s.Sport)
                .HasForeignKey(s => s.SportId)
                .IsRequired();
        }
    }
}
