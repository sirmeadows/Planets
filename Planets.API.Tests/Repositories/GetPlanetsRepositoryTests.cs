using Planets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Planets.API.Tests.Repositories
{
    public class GetPlanetsRepositoryTests
    {
        private PlanetsDbContext _context;

        public GetPlanetsRepositoryTests()
        {
            _context = MockDbContext.Create();
        }

        [Fact]
        public void DataIsReturned()
        {
            var repo = new GetPlanetsRepository(_context);

            var planets = repo.GetPlanets();

            Assert.True(planets.Any());
            Assert.Equal(8, planets.Count());
        }

        [Theory]
        [InlineData(1, "Mercury")]
        [InlineData(2, "Venus")]
        [InlineData(3, "Earth")]
        [InlineData(4, "Mars")]
        [InlineData(5, "Jupiter")]
        [InlineData(6, "Saturn")]
        [InlineData(7, "Uranus")]
        [InlineData(8, "Neptune")]
        public void InitialSeedingWorks(int id, string expectedName)
        {
            var repo = new GetPlanetsRepository(_context);

            var planets = repo.GetPlanets();

            Assert.Equal(expectedName, planets.First(p => p.Id == id).Name);
        }
    }
}
