
namespace Common.Infrastructure.Repository
{
    using Locations.Domain;
    using Microsoft.EntityFrameworkCore;

    public class PracticaExamenContext : DbContext
    {
        public PracticaExamenContext()
        {
        }

        public PracticaExamenContext(DbContextOptions<PracticaExamenContext> options) : base(options)
        {
        }

        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
