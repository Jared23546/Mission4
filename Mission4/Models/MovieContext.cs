using System;
using Microsoft.EntityFrameworkCore; //this is one of the packages that we installed

namespace Mission4.Models

{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {
        //leave blank
        }

        public DbSet<MovieResponse> Responses { get; set; } //responses is a set of data

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Horror",
                    Title = "The Shining",
                    Year = "1980",
                    Director = "Speilberg",
                    Rating = "R",
                    Edited = false,
                    Lentto = "",
                    Notes = "Scariest movie ever!"
                },
                new MovieResponse
                {
                    MovieId = 2,
                    Category = "Action",
                    Title = "End game",
                    Year = "2019",
                    Director = "taiki watiti",
                    Rating = "PG-13",
                    Edited = false,
                    Lentto = "",
                    Notes = "Best movie ever!"
                },
                new MovieResponse
                {
                    MovieId = 3,
                    Category = "Feel good",
                    Title = "Good Will Hunting",
                    Year = "1975",
                    Director = "Matt Damon",
                    Rating = "R",
                    Edited = false,
                    Lentto = "",
                    Notes = "Best movie ever!"
                }
            ); ;
        }

    }
}
