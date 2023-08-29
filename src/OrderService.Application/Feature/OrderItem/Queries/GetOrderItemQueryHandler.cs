

namespace OrderService.Application.Feature.OrderItem.Queries
{
    public class GetOrderItemQueryHandler : IRequestHandler<GetOrderItemQuery, GetOrderItemQueryResponse>
    {
        public Task<GetOrderItemQueryResponse> Handle(GetOrderItemQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
