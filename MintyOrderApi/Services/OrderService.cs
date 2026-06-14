using MintyOrderApi.Models;
using MintyOrderApi.Data;
using Microsoft.EntityFrameworkCore;

namespace MintyOrderApi.Services
{
    public interface IOrderService
    {
        Task<FoodOrder> PlaceOrderAsync(FoodOrder order);
        Task<List<FoodOrder>> GetOrdersAsync();
    }

    public class OrderService : IOrderService
    {
        private readonly OrdersDbContext _db;

        public OrderService(OrdersDbContext db)
        {
            _db = db;
        }

        public async Task<FoodOrder> PlaceOrderAsync(FoodOrder order)
        {
            _db.FoodOrders.Add(order);
            await _db.SaveChangesAsync();
            return order;
        }

        public async Task<List<FoodOrder>> GetOrdersAsync()
        {
            return await _db.FoodOrders.Include(o => o.Items).ToListAsync();
        }
    }
}