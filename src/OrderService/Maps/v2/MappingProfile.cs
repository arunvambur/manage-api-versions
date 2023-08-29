

namespace OrderService.Maps.v2
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<OrderService.ApiModel.v2.Order, OrderService.Domain.Order>().ReverseMap();
        }
    }
}
