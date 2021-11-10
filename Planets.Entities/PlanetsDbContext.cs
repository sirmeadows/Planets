using Microsoft.EntityFrameworkCore;
using Planets.Entities.Extensions;

namespace Planets.Entities
{
    public class PlanetsDbContext : DbContext
    {
        public PlanetsDbContext() : base()
        {

        }

        public PlanetsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Planet> Planets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
