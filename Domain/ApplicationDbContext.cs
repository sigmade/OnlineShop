using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrdersDetails { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<OrderProducts> OrdersProducts { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
