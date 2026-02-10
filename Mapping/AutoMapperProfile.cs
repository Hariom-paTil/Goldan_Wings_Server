using AutoMapper;
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
               opt => opt.MapFrom(src => src.Cakes));

            CreateMap<UserOrderInfo, UserOrderInfoDto>()
                .ForMember(dest => dest.Cakes,
                           opt => opt.MapFrom(src => src.OrderItems));

            CreateMap<CakeOrderListDto, CakeOrderList>().ReverseMap();
            CreateMap<CustomizeCake, CustomizeCakeDto>().ReverseMap();

            CreateMap<AdminLogins, AdminLoginDto>().ReverseMap();
            CreateMap<CustomCakes, CustomCakeDto>().ReverseMap();
           CreateMap<CustomCakeOrder, CustomCakeOrderDto>().ReverseMap();

            CreateMap<CustomCakeUserInfo, CustomCakeUserInfoDto>().ReverseMap();
            CreateMap<AddOnItem, AddOnItemDto>().ReverseMap();
        }
    }
}
