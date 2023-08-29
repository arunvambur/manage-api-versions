namespace OrderService.Domain
{
    public class Order
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Currency { get; set; }
    }
}