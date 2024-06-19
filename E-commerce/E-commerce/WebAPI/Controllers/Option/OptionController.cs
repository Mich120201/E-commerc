using ecommerce.WebAPI.DBQuery.Option.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Option
{
    using ecommerce.Database.DBContext;
    using ecommerce.Models.Option.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : Controller
    {
        private readonly OptionService _OptionService;

        public OptionController(AppDbContext dbContext)
        {

            _OptionService = new OptionService(dbContext);

        }

        [HttpGet]
        public async Task<Option?> Get([FromQuery] Guid id)
        {
            return await _OptionService.GetOptionByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Option product)
        {

            if (await _OptionService.CreateOptionAsync(product))
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
            if (await _OptionService.DeleteOptionAsync(id))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromQuery] Guid id, [FromBody] Option option)
        {
            if (await _OptionService.UpdateOptionAsync(id, option))
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
