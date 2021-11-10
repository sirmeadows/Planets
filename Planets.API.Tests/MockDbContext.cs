using Microsoft.EntityFrameworkCore;
using Planets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.API.Tests
{
    internal static class MockDbContext
    {
        public static PlanetsDbContext Create()
        {
            var options = new DbContextOptionsBuilder<PlanetsDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new PlanetsDbContext(options);

            context.Database.EnsureCreated();

            return context;
        }
    }
}
