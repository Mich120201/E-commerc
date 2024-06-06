using System.Security.Policy;
using ecommerce.DBContext;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Product
{
    using ecommerce.Models.Product.Models;
    using ecommerce.WebAPI.DBQuery.Product;
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
        public async Task<Product?> Get([FromBody] int id)
        {
            return await _productService.GetProductByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {

            if (await _productService.CreateProductAsync(product))
            {
                return Created();
            }
            else
            {
                return Json(new { status = "error", message = "could not create new product" });
            }

        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            if (await _productService.DeleteProductAsync(id))
            {
                return Ok();
            }
            else
            {
                return Json(new { status = "error", message = "could not delete product" });
            }
        }

    }
}
