using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using OrderService.ApiModel.v1;

namespace OrderService.Controllers.v1
{
    [ApiController]
    [Route("api/v1/order")]
    public class OrderController : Controller
    {
        [HttpGet("id")]
        public async Task<IActionResult> GetOrder([FromQuery] int orderId)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostOrder([FromBody]Order order)
        {
            return Ok();
        }
    }
}
