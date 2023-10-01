using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContextClass : DbContext
    {
        public MovieContextClass(DbContextOptions<MovieContextClass> options) : base(options)
        { }
        public DbSet<MovieContextClass> Movies { get; set; }
    }
}
