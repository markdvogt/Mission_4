using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Models
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<FormResponse> Movies { get; set; }  //Movies will be the name of the table in the database
        public DbSet<Category> Categories { get; set; } //Categories will be the name of the second table in the database

        //Seed the database with 5 records
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                //List all the other categories you want in the dropdown menu here
                new Category { CategoryId = 1, CategoryName = "Comedy" },
                new Category { CategoryId = 2, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Horror" },
                new Category { CategoryId = 5, CategoryName = "Thriller" },
                new Category { CategoryId = 6, CategoryName = "Sci-fi" },
                new Category { CategoryId = 7, CategoryName = "Romance" },
                new Category { CategoryId = 8, CategoryName = "Musical" },
                new Category { CategoryId = 9, CategoryName = "Fantasy" },
                new Category { CategoryId = 10, CategoryName = "Rom-Com" }
                );

            mb.Entity<FormResponse>().HasData(

               new FormResponse
               {
                   FormId = 1,
                   CategoryId = 1,
                   Title = "Nacho Libre",
                   Year = 2006,
                   Director = "Jared Hess",
                   Rating = "PG",

               },
               new FormResponse
               {
                   FormId = 2,
                   CategoryId = 6,
                   Title = "Interstellar",
                   Year = 2014,
                   Director = "Christopher Nolan",
                   Rating = "PG-13"
               },
               new FormResponse
               {
                   FormId = 3,
                   CategoryId = 2,
                   Title = "Iron Man",
                   Year = 2008,
                   Director = "Jon Favreau",
                   Rating = "PG-13"
               },
               new FormResponse
               {
                   FormId = 4,
                   CategoryId = 8,
                   Title = "Beauty and the Beast",
                   Year = 2017,
                   Director = "Bill Condon",
                   Rating = "PG"
               },
               new FormResponse
               {
                   FormId = 5,
                   CategoryId = 2,
                   Title = "Spider-Man: No Way Home",
                   Year = 2021,
                   Director = "Jon Watts",
                   Rating = "PG-13"
               } 

            ); 
        }
    }
}
