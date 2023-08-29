
namespace OrderService.Application.Feature.OrderItem.Commands
{
    public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, CreateOrderItemCommandResponse>
    {
        public Task<CreateOrderItemCommandResponse> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
