using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Order
{
    using ecommerce.Database.DBContext;
    using ecommerce.Models.Order.Models;
    using ecommerce.WebAPI.DBQuery.Order.Services;
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly OrderService _OrderService;

        public OrderController(AppDbContext dbContext)
        {

            _OrderService = new OrderService(dbContext);

        }

        [HttpGet]
        public async Task<Order?> Get([FromQuery] Guid id)
        {
            return await _OrderService.GetOrderByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order Order)
        {

            if (await _OrderService.CreateOrderAsync(Order))
            {
                return StatusCode(201, true);
            }
            else
            {
                return StatusCode(500, false);
            }

        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Guid id)
        {
            if (await _OrderService.DeleteOrderAsync(id))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Guid id, [FromBody] Order order)
        {  
            if(await _OrderService.UpdateOrderAsync(id, order))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }
    }
}
