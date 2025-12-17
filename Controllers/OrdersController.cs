using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        OrdersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreateDto dto)
        {
            
            var order = new Order
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Address = dto.Address
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(); 

            
            var orderItems = dto.Cakes.Select(c => new OrderItem
            {
                OrderId = order.OrderId,
                CakeName = c.CakeName,
                Price = c.Price
            }).ToList();

            _context.OrderItems.AddRange(orderItems);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Order placed successfully",
                orderId = order.OrderId
            });
        }
    }
}
