using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Planets.Entities
{
    public class PlanetsDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public PlanetsDbContext(IConfiguration config)
        {
            _config = config;
        }

        public PlanetsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Planet> Planets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(_config.GetConnectionString("Default"));
        }
    }
}
