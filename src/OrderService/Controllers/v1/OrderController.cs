using OrderService.ApiModel.v1;
using OrderService.Application.Feature.Order.Commands;

namespace OrderService.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public OrderController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [MapToApiVersion("1")]
        [HttpGet("id")]
        [ProducesResponseType(typeof(Order), (int)HttpStatusCode.OK) ]
        public async Task<IActionResult> GetOrder([FromQuery] int orderId)
        {
            
            return Ok();
        }

        [MapToApiVersion("1")]
        [HttpPost]
        public async Task<IActionResult> PostOrder([FromBody]Order order)
        {
            var domainOrder = _mapper.Map<Domain.Order>(order);
            var result = _mediator.Send(new CreateOrderCommand { Order = domainOrder });
            var resultOrder = _mapper.Map<Order>(result.Result.Order);
            return Ok(resultOrder);
        }
    }
}
