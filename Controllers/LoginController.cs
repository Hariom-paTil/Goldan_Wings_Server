using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserLogin.DTO;
using UserLogin.Models;
using UserLogin.Repo_Pattern;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserLogin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IGenericRepository<UserLoginInfo> _userRepository;

        public LoginController(IMapper mapper, IGenericRepository<UserLoginInfo> genericRepository)
        {
            
            _mapper = mapper;
            _userRepository = genericRepository;
        }

        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserLoginInfoDto user) 
        {
            var userEntity = _mapper.Map<UserLoginInfo>(user);
            await _userRepository.AddAsync(userEntity);
            return Ok("User Login");


        }                                                      
                                                                  
        


    }
}
