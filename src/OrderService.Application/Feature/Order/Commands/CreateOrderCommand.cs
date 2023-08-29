namespace OrderService.Application.Feature.Order.Commands
{
    public class CreateOrderCommand : IRequest<CreateOrderCommandResponse>
    {
        public Domain.Order Order { get; set; }
    }
}
