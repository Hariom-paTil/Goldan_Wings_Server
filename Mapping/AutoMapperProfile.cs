using AutoMapper;
using System.Runtime;
using UserLogin.DTO;
using UserLogin.Models;

namespace UserLogin.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
           CreateMap<Cakes, CakesDto>().ReverseMap();
            CreateMap<UserLoginInfo, UserLoginInfoDto>().ReverseMap();
            CreateMap<UserOrderInfoDto, UserOrderInfo>()
            .ForMember(dest => dest.OrderItems,
                       opt => opt.MapFrom(src => src.Cakes)).ReverseMap(); 

            CreateMap<CakeOrderListDto, CakeOrderList>().ReverseMap();
            CreateMap<CustomizeCake, CustomizeCakeDto>().ReverseMap();
        }
    }
}
