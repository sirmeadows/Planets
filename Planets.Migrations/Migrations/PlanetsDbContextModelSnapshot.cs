﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Planets.Entities;

#nullable disable

namespace Planets.Migrations.Migrations
{
    [DbContext(typeof(PlanetsDbContext))]
    partial class PlanetsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Planets.Entities.Entities.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("DiameterMiles")
                        .HasColumnType("float");

                    b.Property<int>("LengthOfYearInDays")
                        .HasColumnType("int");

                    b.Property<double>("MassKilograms")
                        .HasColumnType("float");

                    b.Property<double>("MilesFromSun")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Namesake")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiameterMiles = 3031.6700000000001,
                            LengthOfYearInDays = 88,
                            MassKilograms = 0.33000000000000002,
                            MilesFromSun = 35000000.0,
                            Name = "Mercury",
                            Namesake = "Named after the Greek God Hermes' Roman counterpart",
                            PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/771_PIA16853.jpg"
                        },
                        new
                        {
                            Id = 2,
                            DiameterMiles = 7521.0,
                            LengthOfYearInDays = 225,
                            MassKilograms = 4.867,
                            MilesFromSun = 67000000.0,
                            Name = "Venus",
                            Namesake = "Named after Venus, the Roman goddess of love and beauty",
                            PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/688_Venus.jpg"
                        },
                        new
                        {
                            Id = 3,
                            DiameterMiles = 7926.0,
                            LengthOfYearInDays = 365,
                            MassKilograms = 5.9720000000000004,
                            MilesFromSun = 93000000.0,
                            Name = "Earth",
                            Namesake = "A Germanic word, which simply means 'the ground'",
                            PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/786_1-bluemarble_west.jpg"
                        },
                        new
                        {
                            Id = 4,
                            DiameterMiles = 4212.2749999999996,
                            LengthOfYearInDays = 687,
                            MassKilograms = 0.65000000000000002,
                            MilesFromSun = 142000000.0,
                            Name = "Mars",
                            Namesake = "Named by the ancient Romans for their god of war because its reddish color was reminiscent of blood",
                            PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/745_mars_marci.jpg"
                        },
                        new
                        {
                            Id = 5,
                            DiameterMiles = 88846.0,
                            LengthOfYearInDays = 4329,
                            MassKilograms = 1900.0,
                            MilesFromSun = 484000000.0,
                            Name = "Jupiter",
                            Namesake = "Named after the king of the ancient Roman Gods",
                            PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2486_stsci-h-p1936a_1800.jpg"
                        },
                        new
                        {
                            Id = 6,
                            DiameterMiles = 74897.600000000006,
                            LengthOfYearInDays = 10585,
                            MassKilograms = 570.0,
                            MilesFromSun = 889000000.0,
                            Name = "Saturn",
                            Namesake = "Named after the Roman God of agriculture and wealth, who was also the father of Jupiter",
                            PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2490_stsci-h-p1943a-f_1200.jpg"
                        },
                        new
                        {
                            Id = 7,
                            DiameterMiles = 31518.43,
                            LengthOfYearInDays = 30660,
                            MassKilograms = 87.0,
                            MilesFromSun = 1790000000.0,
                            Name = "Uranus",
                            Namesake = "Named after the Greek God of the sky, as suggested by Johann Bode",
                            PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/454_Hubble_Uranus.jpg"
                        },
                        new
                        {
                            Id = 8,
                            DiameterMiles = 30598.799999999999,
                            LengthOfYearInDays = 60225,
                            MassKilograms = 100.0,
                            MilesFromSun = 2800000000.0,
                            Name = "Neptune",
                            Namesake = "Named after the Roman god of the sea, as suggested by Urbain Le Verrier",
                            PictureUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/611_PIA01492.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
