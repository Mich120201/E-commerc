using ecommerce.Database.DBContext;
using ecommerce.Models.Option.Models;
using ecommerce.WebAPI.DBQuery.Option.Services;
using ecommerce.WebAPI.DBQuery.Product.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.Option
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionGroupController : Controller
    {
        private readonly OptionGroupService _OptionGroupService;

        public OptionGroupController(AppDbContext dbContext)
        {

            _OptionGroupService = new OptionGroupService(dbContext);

        }

        [HttpGet]
        public async Task<OptionGroup?> Get([FromQuery] Guid id)
        {
            return await _OptionGroupService.GetOptionGroupByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OptionGroup OptionGroup)
        {

            if (await _OptionGroupService.CreateOptionGroupAsync(OptionGroup))
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
            if (await _OptionGroupService.DeleteOptionGroupAsync(id))
            {
                return StatusCode(200, true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromQuery] Guid id, [FromBody] OptionGroup optiongroup)
        {
            if (await _OptionGroupService.UpdateOptionGroupAsync(id, optiongroup))
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
