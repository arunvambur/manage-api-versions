namespace OrderService.Application.Feature.Order.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var response = new CreateOrderCommandResponse { Id = Guid.NewGuid().ToString(), Message = "Order created successfully", Order = request.Order };
            response.Order.Id = response.Id;
            return response;
        }
    }
}
