using Microsoft.EntityFrameworkCore;

namespace Laba_2.Models
{
    public class FilmAPIContext : DbContext
    {
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet <Director> Directors { get; set; } 
        public virtual DbSet <Film> Films { get; set; }
        public virtual DbSet <FilmStudio> FilmStudios { get; set; }
        public virtual DbSet <Genre> Genres { get; set; }
        public FilmAPIContext(DbContextOptions<FilmAPIContext> options) 
            : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
