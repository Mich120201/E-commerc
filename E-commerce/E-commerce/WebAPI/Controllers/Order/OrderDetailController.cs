using ecommerce.DBContext;
using ecommerce.Models.Order.Models;
using ecommerce.WebAPI.DBQuery.Order.Services;
using ecommerce.WebAPI.DBQuery.Product.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Order
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : Controller
    {
        private readonly OrderDetailService _OrderDetailService;

        public OrderDetailController(AppDbContext dbContext)
        {

            _OrderDetailService = new OrderDetailService(dbContext);

        }

        [HttpGet]
        public async Task<OrderDetail?> Get([FromBody] Guid id)
        {
            return await _OrderDetailService.GetOrderDetailByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderDetail OrderDetail)
        {

            if (await _OrderDetailService.CreateOrderDetailAsync(OrderDetail))
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
            if (await _OrderDetailService.DeleteOrderDetailAsync(id))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Guid id, [FromBody] OrderDetail orderdetail)
        {
            if (await _OrderDetailService.UpdateOrderDetailAsync(id, orderdetail))
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
