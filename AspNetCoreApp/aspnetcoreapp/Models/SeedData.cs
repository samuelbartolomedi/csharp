using Microsoft.EntityFrameworkCore;
using aspnetcoreapp.Data;

namespace aspnetcoreapp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new aspnetcoreappContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<aspnetcoreappContext>>()))
            {
                if (context == null || context.Movie == null || context.Car == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                // Look for any cars.
                if (context.Car.Any())
                {
                    return; //DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );

                context.Car.AddRange(
                    new Car
                    {
                        Brand = "Ford",
                        Model = "Focus",
                        PurchaseDate = DateTime.Parse("2000-1-21"),
                        Price = 10000
                    },

                    new Car
                    {
                        Brand = "Chevrolet",
                        Model = "Onix",
                        PurchaseDate = DateTime.Parse("2021-7-5"),
                        Price = 30000
                    },

                    new Car
                    {
                        Brand = "Fiat",
                        Model = "Uno",
                        PurchaseDate = DateTime.Parse("2006-2-28"),
                        Price = 15000
                    },

                    new Car
                    {
                        Brand = "Renault",
                        Model = "Logan",
                        PurchaseDate = DateTime.Parse("2015-11-16"),
                        Price = 20000
                    }
                 );

                context.SaveChanges();
            }
        }
    }
}
