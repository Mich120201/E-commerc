using ecommerce.DBContext;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Product
{
    using ecommerce.Models.Product.Models;
    using ecommerce.WebAPI.DBQuery.Order.Services;
    using ecommerce.WebAPI.DBQuery.Product.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(AppDbContext dbContext)
        {

            _productService = new ProductService(dbContext);

        }

        [HttpGet]
        public async Task<Product?> Get([FromBody] Guid id)
        {
            return await _productService.GetProductByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            if (await _productService.CreateProductAsync(product))
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
            if (await _productService.DeleteProductAsync(id))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Guid id, [FromBody] Product product)
        {
            if (await _productService.UpdateProductAsync(id, product))
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
