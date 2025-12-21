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
    public class CakesController : ControllerBase
    {
      
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Cakes> _cakeRepository;
        public CakesController(IGenericRepository<Cakes> cakeRepository,IMapper mapper)
        {

            _cakeRepository = cakeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers( )
        {

            var cakeData = await _cakeRepository.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<CakesDto>>(cakeData);
            return Ok(dto);

        }
    }
}
