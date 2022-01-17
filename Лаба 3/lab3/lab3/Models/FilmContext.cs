using System.Data.Entity;

namespace lab3.Models
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}