﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20201026171502_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Travel.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Rating");

                    b.Property<string>("ReviewDetails");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            City = "Seattle",
                            Country = "USA",
                            Rating = 3,
                            ReviewDetails = "Eh"
                        },
                        new
                        {
                            ReviewId = 2,
                            City = "Portland",
                            Country = "USA",
                            Rating = 3,
                            ReviewDetails = "Crazy people"
                        },
                        new
                        {
                            ReviewId = 3,
                            City = "Hawaii",
                            Country = "USA",
                            Rating = 5,
                            ReviewDetails = "Fun"
                        },
                        new
                        {
                            ReviewId = 4,
                            City = "Cape Town",
                            Country = "South Africa",
                            Rating = 4,
                            ReviewDetails = "Nice"
                        },
                        new
                        {
                            ReviewId = 5,
                            City = "Beijing",
                            Country = "China",
                            Rating = 1,
                            ReviewDetails = "Ugh"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
