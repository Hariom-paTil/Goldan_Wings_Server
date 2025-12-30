using UserLogin.DTO;

namespace UserLogin.Admin.Service
{
    public interface IOrderService
    {
        Task<List<UserOrderInfoDto>> GetAllOrdersAsync();
  
    }
}
