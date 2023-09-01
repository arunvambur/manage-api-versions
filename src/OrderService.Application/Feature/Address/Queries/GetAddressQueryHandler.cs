
namespace OrderService.Application.Feature.Address.Queries
{
    public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, GetAddressQueryResponse>
    {
        public Task<GetAddressQueryResponse> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
