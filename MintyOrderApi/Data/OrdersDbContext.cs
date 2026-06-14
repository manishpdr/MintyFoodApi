using Microsoft.EntityFrameworkCore;
using MintyOrderApi.Models;

namespace MintyOrderApi.Data
{
    public class OrdersDbContext : DbContext
    {
        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options) { }

        public DbSet<FoodOrder> FoodOrders => Set<FoodOrder>();
        public DbSet<FoodOrderItem> FoodOrderItems => Set<FoodOrderItem>();
    }
}
