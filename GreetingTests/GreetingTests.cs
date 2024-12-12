using FluentAssertions;
using GreetingApp.Controllers;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace GreetingTests
{
    public class GreetingTests
    {
        private readonly ILogger<GreetingController> _logger = Substitute.For<ILogger<GreetingController>>();

        [Fact]
        public void GreetingShouldReturnHelloWorldIfNoNameProvided()
        {
            var greetingController = new GreetingController(_logger);

            var greeting = greetingController.Greet(null);

            greeting.Should().NotBeNull();
            greeting.Should().Be("Hello, World!");
        }

        [Fact]
        public void GreetingShouldReturnPersonalisedGreetingIfNameProvided()
        {
            var greetingController = new GreetingController(_logger);

            var greeting = greetingController.Greet("Henry");

            greeting.Should().NotBeNull();
            greeting.Should().Be("Hello, Henry!");
        }
    }
}