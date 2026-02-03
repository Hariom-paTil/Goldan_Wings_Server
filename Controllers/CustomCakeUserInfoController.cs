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
    public class CustomCakeUserInfoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<CustomCakeUserInfo> _customCakeUserInfoRepository;


        public CustomCakeUserInfoController(IGenericRepository<CustomCakeUserInfo> customCakeUserInfoRepository, IMapper mapper)
        {
            _customCakeUserInfoRepository = customCakeUserInfoRepository;
            _mapper = mapper;
        }

        [HttpPost("AddUserInfo")]
            public async Task<IActionResult> AddCustomCakeUserInfo([FromBody] CustomCakeUserInfoDto customCakeUserInfo)
        {
            var data = _mapper.Map<CustomCakeUserInfo>(customCakeUserInfo);
            await _customCakeUserInfoRepository.AddAsync(data);
            return Ok("Custom Cake User Info Added");
        }



    }
}
