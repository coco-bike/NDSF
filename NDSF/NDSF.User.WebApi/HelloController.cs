using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NDSF.User.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("api/Hello")]
        public async Task<IActionResult> Hello()
        {
            await Task.CompletedTask;

            return Ok("Hello User");
        }
    }
}
