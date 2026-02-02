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
    public class CakeCustomizeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<CustomizeCake> _customizeCakeRepository;
        public CakeCustomizeController(IGenericRepository<CustomizeCake> customizeCakeRepository, IMapper mapper)
        {
            _customizeCakeRepository = customizeCakeRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomizeCakes()
        {
            var customizeCakeData = await _customizeCakeRepository.GetAllAsync(); // this method only send data to ui it not for order
            var dto = _mapper.Map<IEnumerable<CustomizeCakeDto>>(customizeCakeData);
            return Ok(dto);
        }
    }
}
