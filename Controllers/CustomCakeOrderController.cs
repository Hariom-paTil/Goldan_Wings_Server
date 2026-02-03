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
    public class CustomCakeOrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<CustomCakeOrder> _customCakeOrderRepository;
        public CustomCakeOrderController(IGenericRepository<CustomCakeOrder> customCakeOrderRepository, IMapper mapper)
        {
            _customCakeOrderRepository = customCakeOrderRepository;
            _mapper = mapper;
        }

        [HttpPost("CustomOrder")]
        public async Task<IActionResult> AddCustomCakeOrder([FromBody] CustomCakeOrderDto customCakeOrder)
        {
          
            var data = _mapper.Map<CustomCakeOrder>(customCakeOrder);
            await _customCakeOrderRepository.AddAsync(data);
            return Ok("Custom Cake Added");

        }

    }
}
