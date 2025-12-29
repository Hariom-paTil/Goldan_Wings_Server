using UserLogin.DTO;
using UserLogin.Models;

namespace UserLogin.Service
{
    public interface IUserLoginService
    {
        Task<string> AddNewUserAsync(UserLoginInfoDto dto);
    }
}
