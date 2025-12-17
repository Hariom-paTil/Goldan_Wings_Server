using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreateDto dto) 
        {
            
            var order = new Order  // "Order" actuall Table of database mapping with OrderCreateDto
                                   // dto is work like tempory object to hold the data that came from api and autmatically mapped with OrderCreateDto properties
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Address = dto.Address
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(); 

            
            var orderItems = dto.Cakes.Select(c => new OrderItem  // Mapping OrderItemDto to OrderItem for each cake in the order
            {
                OrderId = order.OrderId,
                CakeName = c.CakeName,
                Price = c.Price
            }).ToList();

            _context.OrderItems.AddRange(orderItems); //AddRange() method is used to add multiple entities to the DbSet in a single call.
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Order placed successfully",
                orderId = order.OrderId
            });
        }
    }
}
