using Microsoft.EntityFrameworkCore;
using personalAPI.Models;

namespace personalAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Order> Orders {get; set;}
    }
}