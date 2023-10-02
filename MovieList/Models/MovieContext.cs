using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) 
            : base(options)
        { }
        public DbSet<MovieClass> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<MovieClass>().HasData(

                    new MovieClass
                    {
                        MovieId = 1,
                        Name = "Casablanca",
                        Year = 1942,
                        Rating = 5
                    },
                    new MovieClass
                    {
                        MovieId = 2,
                        Name = "Wonder Woman",
                        Year = 2017,
                        Rating = 3
                    },
                    new MovieClass
                    {
                        MovieId = 3,
                        Name = "Moonstruck",
                        Year = 1988,
                        Rating = 4
                    }
                );
        }
    }
}
