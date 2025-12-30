using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Identity.Client;
using System.Text.RegularExpressions;
using UserLogin.DTO;
using UserLogin.Repo_Pattern;

namespace UserLogin.Admin.Service
{
    public class AdminLoginService : IAdminLoginService
    {
        private readonly IGenericRepository<Models.AdminLogins> _adminLoginRepository;
        public AdminLoginService(IGenericRepository<Models.AdminLogins> adminLoginRepository)
        {
            _adminLoginRepository = adminLoginRepository;
        }
        
        public async Task<bool> AdminLoginAsync(AdminLoginDto dto)
        {
             
            if (Regex.IsMatch(dto.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase) && 
                await _adminLoginRepository.ExistsAsync(n => n.Email == dto.Email && n.PasswordHash == dto.Password)) {  return true; }
           
            return false;
           
        }

    }
}
