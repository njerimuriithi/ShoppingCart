using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Data
{
    public class ShoppingCartDbContext:DbContext
    {
        //create a constructor
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options):base(options)
        {

        }
        //setdatabase

        public DbSet<Page> Pages { get; set; }

    }
}
