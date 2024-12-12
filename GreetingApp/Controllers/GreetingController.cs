using Microsoft.AspNetCore.Mvc;

namespace GreetingApp.Controllers
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
            // Normally the logic would most likely not be directly implemented in the controller

            if (name == null)
                return "Hello, World!";
            else
                return $"Hello, {name}!";
        }
    }
}
