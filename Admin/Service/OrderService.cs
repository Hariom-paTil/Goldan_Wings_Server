using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UserLogin.DTO;
using UserLogin.Models;
using UserLogin.Repo_Pattern;

namespace UserLogin.Admin.Service
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<UserOrderInfo>  _orderRepository;
       
        private readonly IMapper _mapper;

        private readonly AppDbContext _appContext;
        public OrderService(IGenericRepository<UserOrderInfo> genericRepository, IMapper mapper, AppDbContext appContext) {
        
            _orderRepository = genericRepository;
            _mapper = mapper;  
            _appContext = appContext;

        }

        public async Task<List<UserOrderInfoDto>> GetAllOrdersAsync()
        {
            var orders = await _appContext.Orders
              .Include(o => o.OrderItems) // this .include Method help connect to table 
              .ToListAsync();
            return _mapper.Map<List<UserOrderInfoDto>>(orders);
        }
      
    }
}
