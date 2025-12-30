using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserLogin.Admin.Service;
using UserLogin.DTO;
using UserLogin.Models;
using UserLogin.Repo_Pattern;

namespace UserLogin.Admin.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminLoginController : ControllerBase
    {
        private readonly IAdminLoginService _adminLoginService;
        public AdminLoginController(IAdminLoginService adminLoginService)
        {
          _adminLoginService = adminLoginService;
        }
        [HttpPost]
        public async Task<IActionResult> LoginAdmin([FromBody] AdminLoginDto adminLoginDto)
        {
            bool response = await _adminLoginService.AdminLoginAsync(adminLoginDto);
            return response ? Ok("Admin Valid") : Unauthorized("Admin Login Fail");
        }
        

    }
}
