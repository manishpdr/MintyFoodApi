using Microsoft.AspNetCore.Mvc;
using MintyOrderApi.Models;
using MintyOrderApi.Services;

namespace MintyOrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("place")]
        public async Task<ActionResult<FoodOrder>> PlaceOrder([FromBody] FoodOrder order)
        {
            var placedOrder = await _orderService.PlaceOrderAsync(order);
            return Ok(placedOrder);
        }

        [HttpGet]
        public async Task<ActionResult<List<FoodOrder>>> GetOrders()
        {
            var orders = await _orderService.GetOrdersAsync();
            return Ok(orders);
        }
    }
}
