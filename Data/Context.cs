using Microsoft.EntityFrameworkCore;
using personalAPI.Models;

namespace personalAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Album> Albums {get; set;}
        public DbSet<Artist> Artists {get; set;}
        public DbSet<Genre> Genres {get; set;}
    }
}