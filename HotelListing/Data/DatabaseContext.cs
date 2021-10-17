using HotelListing.Entities;
using HotelListing.Identity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

       

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Republic of South Africa",
                    ShortName = "RSA"
                },
                new Country
                {
                    Id = 2,
                    Name = "Lesotho",
                    ShortName = "LST"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States Of America",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 4,
                    Name = "Republic of Namibia",
                    ShortName = "NMB"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "MGB",
                    Address = "Sibasa, Limpopo",
                    CountryId = 1,
                    Rating = 4.5

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hilton",
                    Address = "Sandton, Gauteng",
                    CountryId = 1,
                    Rating = 4.8

                },
                new Hotel
                {
                    Id = 3,
                    Name = "Trump Tower",
                    Address = "New York",
                    CountryId = 3,
                    Rating = 4.8

                },
               new Hotel
               {
                   Id = 4,
                   Name = "Four Seasons",
                   Address = "WindHoek",
                   CountryId = 4,
                   Rating = 3.8

               },
               new Hotel
               {
                   Id = 5,
                   Name = "Sun Hotel",
                   Address = "Maseru",
                   CountryId = 2,
                   Rating = 3.5

               }
               );
        }
    }
}
