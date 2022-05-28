using Microsoft.AspNetCore.Mvc;

namespace NDSF.WebAPI
{
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("api/Hello")]
        public async Task<IActionResult> Hello()
        {
            await Task.CompletedTask;

            return Ok("Hello Dapr");
        }
    }
}
