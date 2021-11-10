namespace Planets.BusinessLogicLayer.Repositories
{
    public interface IGetPlanetsRepository
    {
        IEnumerable<PlanetDto> GetPlanets();
    }
}