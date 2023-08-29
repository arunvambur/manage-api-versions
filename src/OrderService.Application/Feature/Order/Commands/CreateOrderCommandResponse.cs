namespace OrderService.Application.Feature.Order.Commands
{
    public class CreateOrderCommandResponse
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public Domain.Order Order { get; set; }
    }
}
