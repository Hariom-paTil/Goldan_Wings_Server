using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserLogin.DTO;
using UserLogin.Models;
using UserLogin.Repo_Pattern;

namespace UserLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMapper _mapper;
         private readonly IGenericRepository<UserOrderInfo> _orderRepository;


        public OrdersController(IMapper mapper, IGenericRepository<UserOrderInfo> genericRepository)
        {
            
            _mapper = mapper;
            _orderRepository = genericRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] UserOrderInfoDto userOrderInfoDto) 
        {
            var orderEntity = _mapper.Map<UserOrderInfo>(userOrderInfoDto);

            await _orderRepository.AddAsync(orderEntity);

            return  Ok("Order placed successfully");
        }
    }
}
