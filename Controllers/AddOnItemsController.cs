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
    public class AddOnItemsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<AddOnItem> _genericRepository;

        public AddOnItemsController(IMapper mapper, IGenericRepository<AddOnItem> genericRepository)
        {
            _mapper = mapper;
            _genericRepository = genericRepository;
        }
        [HttpPost("AddOnItems")]

        public async Task<IActionResult> InsertNewItem([FromBody] AddOnItemDto dto)
        {
            var data = _mapper.Map<AddOnItem>(dto);
            await _genericRepository.AddAsync(data);
            return Ok(true);

        }
        [HttpGet("GetAddOnItems")]

        public async Task<IActionResult> GetAddItemData()
        {
            var data = await _genericRepository.GetAllAsync();
            var responceBody = _mapper.Map<List<AddOnItemDto>>(data);
            return Ok(responceBody);

        }
    }
}
