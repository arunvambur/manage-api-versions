using OrderService.ApiModel.v2;

namespace OrderService.Controllers.v2
{
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class OrderItemController : Controller
    {
        [MapToApiVersion("2")]
        [HttpGet("id")]
        [ProducesResponseType(typeof(OrderItem), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetOrderItems([FromQuery] int orderId)
        {
            return Ok();
        }

        [MapToApiVersion("2")]
        [HttpPost]
        public async Task<IActionResult> PostOrderItems([FromBody] OrderItem order)
        {
            return Ok();
        }
    }
}
