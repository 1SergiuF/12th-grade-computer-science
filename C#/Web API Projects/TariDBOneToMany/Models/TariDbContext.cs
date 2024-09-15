using Microsoft.EntityFrameworkCore;

namespace TariDBOneToMany.Models
{
    public class TariDbContext : DbContext
    {
        public TariDbContext(DbContextOptions<TariDbContext> options) : base(options) { }

        public DbSet<Locuitor> locuitori { get; set; }
        public DbSet<Tara> tari { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tara>()
                .HasMany(t => t.Locuitori)
                .WithOne(l => l.Tara)
                .HasForeignKey(l => l.TaraId)
                .IsRequired();
        }
    }
}
