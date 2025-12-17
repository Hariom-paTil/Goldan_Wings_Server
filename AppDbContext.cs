using Microsoft.EntityFrameworkCore;
using UserLogin.Controllers;

namespace UserLogin
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) // base keyword insures the parent class all information is read before executing the child class 
     
        {

        }
        public DbSet<Cake> Cakes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
