using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planets.Entities.Entities
{
    public class Planet
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(7)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string PictureUrl { get; set; }
        public double MilesFromSun { get; set; }
        public double MassKilograms { get; set; }
        public double DiameterMiles { get; set; }
        [MaxLength(500)]
        public string Namesake { get; set; }
        public int LengthOfYearInDays { get; set; }
    }
}
