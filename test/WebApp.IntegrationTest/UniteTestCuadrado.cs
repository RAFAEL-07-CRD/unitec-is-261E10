using Xunit;

using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApp.IntegationTest
{
    public class IntegationTestPages : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;
        public IntegationTestPages(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("Index")]
        [InlineData("Area")]
        [InlineData("ALTURA")]
        [InlineData("Base")]
        [InlineData("Medidas")]

        public async Task TestPageStatusCode(string url)
        {
            // Arrange – Set up

            // Act – Perform
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Assert – Verify
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}