using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Product
{
    using System.Runtime.InteropServices.ObjectiveC;
    using ecommerce.Database.DBContext;
    using ecommerce.Models.Option.Models;
    using ecommerce.Models.Product.Models;
    using ecommerce.WebAPI.DBQuery.Option.Interfaces;
    using ecommerce.WebAPI.DBQuery.Option.Services;
    using ecommerce.WebAPI.DBQuery.Order.Services;
    using ecommerce.WebAPI.DBQuery.Product.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {

        private readonly ProductService _productService;
        private readonly ProductOptionService _productOptionService;
        private readonly OptionGroupService _optionGroupService;
        private readonly OptionService _optionService;
        private readonly ThumbImageService _thumbImageService;

        public ProductController(AppDbContext dbContext)
        {

            _productService = new ProductService(dbContext);
            _optionGroupService = new OptionGroupService(dbContext);
            _optionService = new OptionService(dbContext);
            _productOptionService = new ProductOptionService(dbContext);
            _thumbImageService = new ThumbImageService(dbContext);

        }

        [HttpGet]
        public async Task<Product?> Get(Guid id)
        {
            return await _productService.GetProductByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
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
        public async Task<IActionResult> Delete(Guid id)
        {
            if (await _productService.SoftDeleteProductAsync(id))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Guid id, Product product)
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
