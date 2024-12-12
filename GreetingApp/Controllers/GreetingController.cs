using Microsoft.AspNetCore.Mvc;

namespace GreetingApp3.Controllers
{
    [ApiController]
    [Route("")]
    public class GreetingController : ControllerBase
    {
        private readonly ILogger<GreetingController> _logger;

        public GreetingController(ILogger<GreetingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGreeting")]
        public string Greet(string? name)
        {
            if (name == null)
                return "Hello, World!";
            else
                return $"Hello, {name}!";
        }
    }
}
