﻿// <auto-generated />
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelListing.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211016210720_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelListing.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Republic of South Africa",
                            ShortName = "RSA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lesotho",
                            ShortName = "LST"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United States Of America",
                            ShortName = "USA"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Republic of Namibia",
                            ShortName = "NMB"
                        });
                });

            modelBuilder.Entity("HotelListing.Entities.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sibasa, Limpopo",
                            CountryId = 1,
                            Name = "MGB",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "Sandton, Gauteng",
                            CountryId = 1,
                            Name = "Hilton",
                            Rating = 4.7999999999999998
                        },
                        new
                        {
                            Id = 3,
                            Address = "New York",
                            CountryId = 3,
                            Name = "Trump Tower",
                            Rating = 4.7999999999999998
                        },
                        new
                        {
                            Id = 4,
                            Address = "WindHoek",
                            CountryId = 4,
                            Name = "Four Seasons",
                            Rating = 3.7999999999999998
                        },
                        new
                        {
                            Id = 5,
                            Address = "Maseru",
                            CountryId = 2,
                            Name = "Sun Hotel",
                            Rating = 3.5
                        });
                });

            modelBuilder.Entity("HotelListing.Entities.Hotel", b =>
                {
                    b.HasOne("HotelListing.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}
