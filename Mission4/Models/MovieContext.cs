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

        //this pulls data from the responses table
        public DbSet<MovieResponse> Responses { get; set; } //responses is a set of data

        public DbSet<Category> Categories { get; set; } //Categories is a set of data from the category table


        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seed the category table
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Horror" },
                new Category { CategoryId = 2, CategoryName = "Action" },
                new Category { CategoryId = 3, CategoryName = "Romance" }
            );

            //seed the movie data
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
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
                    CategoryId = 2,
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
                    CategoryId = 3,
                    Title = "Good Will Hunting",
                    Year = "1975",
                    Director = "Matt Damon",
                    Rating = "R",
                    Edited = false,
                    Lentto = "",
                    Notes = "Best movie ever!"
                }
            );
            
        }

    }
}
