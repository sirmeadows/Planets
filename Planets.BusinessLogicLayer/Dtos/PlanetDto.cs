namespace Planets.BusinessLogicLayer.Dtos
{
    public class PlanetDto
    {
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public double MilesFromSun { get; set; }
        public double KilometersFromSun { get => MilesFromSun.MilesToKilometers(); }
        public double BananasFromSun { get => MilesFromSun.MilesToBananas(); }
        public double MassKilograms { get; set; }
        public double DiameterMiles { get; set; }
        public double DiameterKilometers { get => MilesFromSun.MilesToKilometers(); }
        public double DiameterBananas { get => MilesFromSun.MilesToBananas(); }
    }
}
