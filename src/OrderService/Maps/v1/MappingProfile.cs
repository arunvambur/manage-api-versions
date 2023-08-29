namespace OrderService.Maps.v1
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<OrderService.ApiModel.v1.Order, OrderService.Domain.Order>().ReverseMap();
        }
    }
}
