using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EchoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        [HttpGet]
        public object Get([FromQuery] string? text) => !string.IsNullOrEmpty(text) ? new { echo = text, dateTime = DateTime.UtcNow } : new { echo = "Hello, World!", dateTime = DateTime.UtcNow };
    }
}
