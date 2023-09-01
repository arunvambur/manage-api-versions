using OrderService.ApiModel;
using OrderService.Application.Feature.Order.Commands;

namespace OrderService.Controllers
{
    [ApiVersion("1")]
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public AddressController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [MapToApiVersion("1")]
        [MapToApiVersion("2")]
        [HttpGet("id")]
        [ProducesResponseType(typeof(Address), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAddress([FromQuery] int addressId)
        {
            return Ok();
        }

        [MapToApiVersion("1")]
        [MapToApiVersion("2")]
        [HttpPost]
        public async Task<IActionResult> PostOrder([FromBody] Address address)
        {
            return Ok();
        }
    }
}
