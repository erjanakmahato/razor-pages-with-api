using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMovie.Models
{
    public class SeedData
    {
        public static void Initializer(IServiceProvider serviceProvider)
        {
            using(var context=new RazorPageMovieContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPageMovieContext>>()))
            {
                //look for any movies
                if (context.Movie.Any())
                {
                    return;//Db has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When harry met sally",
                        ReleaseDate = DateTime.Parse("1980-02-12"),
                        Genre = "Romantic",
                        Price = 7.99M,
                        Rating="r"
                    },
                    new Movie
                    {
                        Title="John Wick",
                        ReleaseDate=DateTime.Parse("2017-01-12"),
                        Genre="Comedy Action Adventures",
                        Price=12M,
                        Rating = "r"
                    },
                    new Movie
                    {
                        Title="John Wick-Chapter-2",
                        ReleaseDate=DateTime.Parse("2018-02-12"),
                        Price=30M,
                        Rating = "r"
                    },
                    new Movie
                    {
                        Title="John Wick-Chapter-3",
                        ReleaseDate=DateTime.Parse("2019-09-09"),
                        Price=60M,
                        Rating = "r"
                    },
                    new Movie
                    {
                        Title="Rio Bravo",
                        ReleaseDate=DateTime.Parse("1959-2-23"),
                        Price=8.99M,
                        Rating = "r"
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
