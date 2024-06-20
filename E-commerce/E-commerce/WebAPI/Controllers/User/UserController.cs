using ecommerce.WebAPI.DBQuery.User.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebAPI.Controllers.User
{
    using ecommerce.Database.DBContext;
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserService _UserService;

        public UserController(AppDbContext dbContext)
        {

            _UserService = new UserService(dbContext);

        }
    }
}
