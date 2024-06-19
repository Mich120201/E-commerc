using ecommerce.Database.Blob;
using ecommerce.Database.DBContext;
using ecommerce.Models.Product.Models;
using ecommerce.WebAPI.DBQuery.Blob.Services;
using ecommerce.WebAPI.DBQuery.Product.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Blob
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobController : Controller
    {
        private readonly BlobService _BlobService;
        private readonly ThumbImageService _ThumbImageService;

        public BlobController(AppDbContext dbContext, BlobConfig blobConfig)
        {

            _BlobService = new BlobService(blobConfig);
            _ThumbImageService = new ThumbImageService(dbContext);

        }

        [HttpGet]
        public async Task<IActionResult?> Get([FromBody] Guid id)
        {
            ThumbImage? thumbImage = await _ThumbImageService.GetThumbImageByIdAsync(id);
            if (thumbImage != null)
            {
                return StatusCode(200, thumbImage.ThumbImageLink);
            }
            else
            {
                return StatusCode(404, false);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] String localfilepath)
        {

            if (await _BlobService.UploadAsync(localfilepath))
            {
                return StatusCode(201, true);
            }
            else
            {
                return StatusCode(500, false);
            }

        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] String filename)
        {
            if (await _BlobService.DeleteAsync(filename))
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
