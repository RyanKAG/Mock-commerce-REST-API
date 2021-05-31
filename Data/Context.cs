using Microsoft.EntityFrameworkCore;
using personalAPI.Models;

namespace personalAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Artist>()
            .Property(i => i.Name).HasMaxLength(256);

            builder.Entity<Artist>()
                .HasIndex(Artist => Artist.Name)
                .IsUnique();
            }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}