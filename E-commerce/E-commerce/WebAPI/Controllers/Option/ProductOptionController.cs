using ecommerce.Database.DBContext;
using ecommerce.Models.Option.Models;
using ecommerce.WebAPI.DBQuery.Option.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Option
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOptionController : Controller
    {
        private readonly ProductOptionService _ProductOptionService;

        public ProductOptionController(AppDbContext dbContext)
        {

            _ProductOptionService = new ProductOptionService(dbContext);

        }

        [HttpGet]
        public async Task<ProductOption?> Get([FromQuery] Guid id)
        {
            return await _ProductOptionService.GetProductOptionByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductOption ProductOption)
        {

            if (await _ProductOptionService.CreateProductOptionAsync(ProductOption))
            {
                return StatusCode(201, true);
            }
            else
            {
                return StatusCode(500, false);
            }

        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] Guid id)
        {
            if (await _ProductOptionService.DeleteProductOptionAsync(id))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromQuery] Guid id, [FromBody] ProductOption productoption)
        {
            if (await _ProductOptionService.UpdateProductOptionAsync(id, productoption))
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
