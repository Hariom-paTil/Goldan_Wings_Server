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
    public class CustomCakeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<CustomCakes> _customCakeRepository;

        public CustomCakeController(IGenericRepository<CustomCakes> customCakeRepository, IMapper mapper)
        {
            _customCakeRepository = customCakeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomCakes()
        {
            var customCakeData = await _customCakeRepository.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<CustomCakes>>(customCakeData);
            return Ok(dto);
        }

        [HttpPost("AddCakes")]
        public async Task<IActionResult> AddCustomCake([FromBody]CustomCakeDto customCake)
        {
         
            var customCakeEntity = _mapper.Map<CustomCakes>(customCake);
            await _customCakeRepository.AddAsync(customCakeEntity);
            return Ok("Custom cake added successfully");
        }
    }
}
