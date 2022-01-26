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

        //Seed the database with 5 records
        protected override void OnModelCreating(ModelBuilder mb)
        { 
            mb.Entity<FormResponse>().HasData(

               new FormResponse
               {
                   FormId = 1,
                   Category = "Comedy",
                   Title = "Nacho Libre",
                   Year = 2006,
                   Director = "Jared Hess",
                   Rating = "PG",

               },
               new FormResponse
               {
                   FormId = 2,
                   Category = "Sci-fi/Adventure",
                   Title = "Interstellar",
                   Year = 2014,
                   Director = "Christopher Nolan",
                   Rating = "PG-13"
               },
               new FormResponse
               {
                   FormId = 3,
                   Category = "Action/Adventure",
                   Title = "Iron Man",
                   Year = 2008,
                   Director = "Jon Favreau",
                   Rating = "PG-13"
               },
               new FormResponse
               {
                   FormId = 4,
                   Category = "Musical/Romance",
                   Title = "Beauty and the Beast",
                   Year = 2017,
                   Director = "Bill Condon",
                   Rating = "PG"
               },
               new FormResponse
               {
                   FormId = 5,
                   Category = "Action/Adventure",
                   Title = "Spider-Man: No Way Home",
                   Year = 2021,
                   Director = "Jon Watts",
                   Rating = "PG-13"
               } 

            ); 
        }
    }
}
