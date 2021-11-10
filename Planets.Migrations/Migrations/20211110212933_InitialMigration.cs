using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planets.Migrations.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MilesFromSun = table.Column<double>(type: "float", nullable: false),
                    MassKilograms = table.Column<double>(type: "float", nullable: false),
                    DiameterMiles = table.Column<double>(type: "float", nullable: false),
                    Namesake = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LengthOfYearInDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "DiameterMiles", "LengthOfYearInDays", "MassKilograms", "MilesFromSun", "Name", "Namesake", "PictureUrl" },
                values: new object[,]
                {
                                { 1, 3031.6700000000001, 88, 5.9400000000000004, 35000000.0, "Mercury", "Named after the Greek God Hermes' Roman counterpart", "https://solarsystem.nasa.gov/system/resources/detail_files/771_PIA16853.jpg" },
                                { 2, 7521.0, 225, 87.605999999999995, 67000000.0, "Venus", "Named after Venus, the Roman goddess of love and beauty", "https://solarsystem.nasa.gov/system/resources/detail_files/688_Venus.jpg" },
                                { 3, 7926.0, 365, 107.49600000000001, 93000000.0, "Earth", "A Germanic word, which simply means 'the ground'", "https://solarsystem.nasa.gov/system/resources/detail_files/786_1-bluemarble_west.jpg" },
                                { 4, 4212.2749999999996, 687, 11.700000000000001, 142000000.0, "Mars", "Named by the ancient Romans for their god of war because its reddish color was reminiscent of blood", "https://solarsystem.nasa.gov/system/resources/detail_files/745_mars_marci.jpg" },
                                { 5, 88846.0, 4329, 34200.0, 484000000.0, "Jupiter", "Named after the king of the ancient Roman Gods", "https://solarsystem.nasa.gov/system/resources/detail_files/2486_stsci-h-p1936a_1800.jpg" },
                                { 6, 74897.600000000006, 10585, 10260.0, 889000000.0, "Saturn", "Named after the Roman God of agriculture and wealth, who was also the father of Jupiter", "https://solarsystem.nasa.gov/system/resources/detail_files/2490_stsci-h-p1943a-f_1200.jpg" },
                                { 7, 31518.43, 30660, 1566.0, 1790000000.0, "Uranus", "Named after the Greek God of the sky, as suggested by Johann Bode", "https://solarsystem.nasa.gov/system/resources/detail_files/454_Hubble_Uranus.jpg" },
                                { 8, 30598.799999999999, 60225, 1800.0, 2800000000.0, "Neptune", "Named after the Roman god of the sea, as suggested by Urbain Le Verrier", "https://solarsystem.nasa.gov/system/resources/detail_files/611_PIA01492.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
    table: "Planets",
    keyColumn: "Id",
    keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
