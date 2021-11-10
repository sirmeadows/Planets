using Planets.Entities;

namespace Planets.BusinessLogicLayer.Repositories
{
    public class GetPlanetsRepository : IGetPlanetsRepository
    {
        private readonly PlanetsDbContext _context;

        public GetPlanetsRepository(PlanetsDbContext context)
        {
            _context=context;
        }

        public IEnumerable<PlanetDto> GetPlanets()
        {
            // Can be replaced with AutoMapper if the app gets bigger
            // For now this can be manual
            return _context.Planets.Select(p => new PlanetDto
            {
                Id = p.Id,
                Name = p.Name,
                DiameterMiles = p.DiameterMiles,
                MassKilograms = p.MassKilograms,
                MilesFromSun = p.MilesFromSun,
                PictureUrl = p.PictureUrl
            });
        }
    }
}
