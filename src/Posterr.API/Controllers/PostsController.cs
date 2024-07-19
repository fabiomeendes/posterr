using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Posterr.Posts.Application.InputModels;
using Posterr.Posts.Application.Services;

namespace Posterr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostInputModel request)
        {
            return Ok(await _postService.CreatePostAsync(request));
        }
    }
}
