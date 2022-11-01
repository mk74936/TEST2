using Microsoft.EntityFrameworkCore;
using TEST2.API.Models.Domain;

namespace TEST2.API.Data
{
    public class TEST2DbContext:DbContext
    {
        public TEST2DbContext(DbContextOptions<TEST2DbContext> options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
