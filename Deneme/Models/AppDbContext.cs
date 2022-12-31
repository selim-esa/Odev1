using Microsoft.EntityFrameworkCore;


namespace Deneme.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options ) : base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

    }
}
