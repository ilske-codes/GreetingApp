using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace IntegrationTests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public IntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GreetingIsGenericIfNoNameParameterSet()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/");

            // Check if there is a response
            response.EnsureSuccessStatusCode();
            response.Should().NotBeNull();
            response.Content.Should().NotBeNull();
            response.Content.Headers.Should().NotBeNull();

            // Check that the response is correct (ideally this would be a separate test)
            var headers = response.Content.Headers.ContentType.ToString();
            var content = await response.Content.ReadAsStringAsync();

            headers.Should().Be("text/plain; charset=utf-8");
            content.Should().Be("Hello, World!");
        }

        [Fact]
        public async Task GreetingUsesNameIfNameParameterIsSet()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/?name=Janet");

            // Check if there is a response
            response.EnsureSuccessStatusCode();
            response.Should().NotBeNull();
            response.Content.Should().NotBeNull();
            response.Content.Headers.Should().NotBeNull();

            // Check that the response is correct (ideally this would be a separate test)
            var headers = response.Content.Headers.ContentType.ToString();
            var content = await response.Content.ReadAsStringAsync();

            headers.Should().Be("text/plain; charset=utf-8");
            content.Should().Be("Hello, Janet!");
        }
    }
}