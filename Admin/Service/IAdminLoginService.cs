using UserLogin.DTO;

namespace UserLogin.Admin.Service
{
    public interface IAdminLoginService
    {
        Task<bool> AdminLoginAsync(AdminLoginDto entity);
    }
}
