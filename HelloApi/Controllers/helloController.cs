using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok("Hello, welcome to ASP.NET Web API!");
        }

        [HttpGet("time")]
        public IActionResult GetTime()
        {
            return Ok(DateTime.Now);
        }
    }
}
