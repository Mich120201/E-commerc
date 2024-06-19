using ecommerce.Database.DBContext;
using ecommerce.Models.Product.Models;
using ecommerce.WebAPI.DBQuery.Product.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.thumbimage
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThumbImageController : Controller
    {
        private readonly ThumbImageService _thumbImageService;

        public ThumbImageController(AppDbContext dbContext)
        {

            _thumbImageService = new ThumbImageService(dbContext);

        }

        [HttpGet]
        public async Task<ThumbImage?> Get([FromBody] Guid id)
        {
            return await _thumbImageService.GetThumbImageByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ThumbImage thumbImage)
        {

            if (await _thumbImageService.CreateThumbImageAsync(thumbImage))
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
            if (await _thumbImageService.DeleteThumbImageAsync(id))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Guid id, [FromBody] ThumbImage thumbImage)
        {
            if (await _thumbImageService.UpdateThumbImageAsync(id, thumbImage))
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
