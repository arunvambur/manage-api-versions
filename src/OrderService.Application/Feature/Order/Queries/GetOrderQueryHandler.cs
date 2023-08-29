

namespace OrderService.Application.Feature.Order.Queries
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, GetOrderQueryResponse>
    {
        public Task<GetOrderQueryResponse> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
