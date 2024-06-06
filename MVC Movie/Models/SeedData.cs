using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mvc_Movie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Mvc_MovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Mvc_MovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Matrix",
                    ReleaseDate = DateTime.Parse("1999-01-04"),
                    Genre = "Sci-fi",
                    Rating = "5",
                    Price = 100M
                },
                new Movie
                {
                    Title = "Godzilla ",
                    ReleaseDate = DateTime.Parse("2024-07-04"),
                    Genre = "Action",
                    Rating = "4",
                    Price = 200M
                },
                new Movie
                {
                    Title = "Pushpa",
                    ReleaseDate = DateTime.Parse("2022-06-18"),
                    Genre = "Action",
                    Rating = "5",
                    Price = 12.5M
                },
                new Movie
                {
                    Title = "Tarzen",
                    ReleaseDate = DateTime.Parse("2005-02-15"),
                    Genre = "Action",
                    Rating = "5",
                    Price = 7.0M
                },
                new Movie
                {
                    Title = "jatt & julliet",
                    ReleaseDate = DateTime.Parse("2008-02-05"),
                    Genre = "comedy",
                    Rating = "4",
                    Price = 9.0M
                }
            );
            context.SaveChanges();
        }
    }
}