using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(
            serviceProvider.GetRequiredService<DbContextOptions<MVCAppContext>>()))

            {
                if (context.Movie.Any())
                {
                    //look for any movies
                    return; //DB has been
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Avenger 1",
                        RealeseDate = DateTime.Parse("1989-2-12") ,
                        Genre = "Fiction",
                        Price = 98.23M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Avenger 2",
                        RealeseDate = DateTime.Parse("2014-2-12") ,
                        Genre = "Fiction",
                        Price = 45.45M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Avenger 3",
                        RealeseDate = DateTime.Parse("2021-2-12"),
                        Genre = "Fiction",
                        Price = 145.47M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Avenger 4",
                        RealeseDate = DateTime.Parse("2014-2-12"),
                        Genre = "Fiction",
                        Price = 45.45M,
                        Rating = "R"
                    }
                    );
                context.SaveChanges();
            }
        }
        
    }
}
