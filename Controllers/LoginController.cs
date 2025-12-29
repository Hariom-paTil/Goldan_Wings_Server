using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserLogin.DTO;
using UserLogin.Models;
using UserLogin.Repo_Pattern;
using UserLogin.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserLogin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {

     
        private readonly IUserLoginService _userLoginService;

        public LoginController(IUserLoginService userLoginService)
        {
            
       
            _userLoginService = userLoginService;
        }

        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserLoginInfoDto user) 
        {
      

           var response= await _userLoginService.AddNewUserAsync(user);
            return Ok(response);

        }                                                      
                                                                  
        


    }
}
