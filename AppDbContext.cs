using Microsoft.EntityFrameworkCore;
using UserLogin.Models;

namespace UserLogin
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) // base keyword insures the parent class all information is read before executing the child class 
     
        {

        }

        public DbSet<CustomizeCake>  Customize_Cake { get; set; }
        public DbSet<Cakes> Cakes { get; set; }

        public DbSet<UserLoginInfo> Users { get; set; }

        public DbSet<UserOrderInfo> Orders { get; set; }

        public DbSet<CakeOrderList> OrderItems { get; set; }

        public DbSet<AdminLogins> AdminLogin { get; set; }

        public DbSet<CustomCakes> CustomCake { get; set; }

        public DbSet<CustomCakeOrder> CustomCakeOrder { get; set; }

        public DbSet<CustomCakeUserInfo> CustomerCakeUserInfo { get; set; }

        public DbSet<AddOnItem> AddOnItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserOrderInfo>()
                .HasMany(o => o.OrderItems)
                .WithOne(c => c.Order)
                .HasForeignKey(c => c.OrderId);
        }
    }
}
