using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Posterr.Users.Application.Services;

namespace Posterr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);

            return Ok(user);
        }
    }
}
