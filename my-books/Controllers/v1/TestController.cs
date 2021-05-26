using Microsoft.AspNetCore.Mvc;

namespace my_books.Controllers.v1
{
    [ApiVersion("1.0")]
    // [Route("api/[controller]")] // Query Versioning
    [Route("api/v{version:apiVersion}/[controller]")] // Path Versioning
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get-test-data")]
        public IActionResult Get()
        {
            return Ok("This is TestController V1");
        }
    }
}