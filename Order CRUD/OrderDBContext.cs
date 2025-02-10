using Microsoft.EntityFrameworkCore;
using Order_CRUD.Entity;

namespace Order_CRUD
{
    public class OrderDBContext:DbContext
    {
        public OrderDBContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Order> Orders { get; set; }
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Product> Products { get; set; }
    }
}
