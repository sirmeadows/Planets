using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Entities.Extensions
{
    internal static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>().HasData(
                new Planet
                {
                    Id = 1,
                    Name = "Mercury",
                    DiameterMiles = 3031.67,
                    MassKilograms = Convert.ToDouble(0.33d),
                    MilesFromSun = 35000000,
                    LengthOfYearInDays = 88,
                    Namesake = "Named after the Greek God Hermes' Roman counterpart",
                    PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/771_PIA16853.jpg"
                },
                new Planet
                {
                    Id = 2,
                    Name = "Venus",
                    DiameterMiles = 7521,
                    MassKilograms = Convert.ToDouble(4.867d),
                    MilesFromSun = 67000000,
                    LengthOfYearInDays = 225,
                    Namesake = "Named after Venus, the Roman goddess of love and beauty",
                    PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/688_Venus.jpg"
                },
                new Planet
                {
                    Id = 3,
                    Name = "Earth",
                    DiameterMiles = 7926,
                    MassKilograms = Convert.ToDouble(5.972d),
                    MilesFromSun = 93000000,
                    LengthOfYearInDays = 365,
                    Namesake = "A Germanic word, which simply means 'the ground'",
                    PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/786_1-bluemarble_west.jpg"
                },
                new Planet
                {
                    Id = 4,
                    Name = "Mars",
                    DiameterMiles = 4212.275,
                    MassKilograms = Convert.ToDouble(0.65d),
                    MilesFromSun = 142000000,
                    LengthOfYearInDays = 687,
                    Namesake = "Named by the ancient Romans for their god of war because its reddish color was reminiscent of blood",
                    PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/745_mars_marci.jpg"
                },
                new Planet
                {
                    Id = 5,
                    Name = "Jupiter",
                    DiameterMiles = 88846,
                    MassKilograms = Convert.ToDouble(1900d),
                    MilesFromSun = 484000000,
                    LengthOfYearInDays = 4329,
                    Namesake = "Named after the king of the ancient Roman Gods",
                    PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2486_stsci-h-p1936a_1800.jpg"
                },
                new Planet
                {
                    Id = 6,
                    Name = "Saturn",
                    DiameterMiles = 74897.6,
                    MassKilograms = Convert.ToDouble(570d),
                    MilesFromSun = 889000000,
                    LengthOfYearInDays = 10585,
                    Namesake = "Named after the Roman God of agriculture and wealth, who was also the father of Jupiter",
                    PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2490_stsci-h-p1943a-f_1200.jpg"
                },
                new Planet
                {
                    Id = 7,
                    Name = "Uranus",
                    DiameterMiles = 31518.43,
                    MassKilograms = Convert.ToDouble(87d),
                    MilesFromSun = 1790000000,
                    LengthOfYearInDays = 30660,
                    Namesake = "Named after the Greek God of the sky, as suggested by Johann Bode",
                    PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/454_Hubble_Uranus.jpg"
                },
                new Planet
                {
                    Id = 8,
                    Name = "Neptune",
                    DiameterMiles = 30598.8,
                    MassKilograms = Convert.ToDouble(100d),
                    MilesFromSun = 2800000000,
                    LengthOfYearInDays = 60225,
                    Namesake = "Named after the Roman god of the sea, as suggested by Urbain Le Verrier",
                    PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/611_PIA01492.jpg"
                });
        }
    }
}
