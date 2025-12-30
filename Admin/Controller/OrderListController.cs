using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserLogin.Admin.Service;

namespace UserLogin.Admin.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderListController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderListController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _orderService.GetAllOrdersAsync();
            return Ok(orders);
        }
    }
}
