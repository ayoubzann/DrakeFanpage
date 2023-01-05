using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FanpageNUnitTest
{
    public class Tests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ValuesControllerTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Test]
        public async Task TestGet()
        {
            // Send a GET request to the API
            var response = await _client.GetAsync("/api/values");

            // Assert that the response status code is 200 (OK)
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [Test]
        public async Task TestPost()
        {
            // Send a POST request to the API
            var response = await _client.PostAsync("/api/values", new StringContent("test"));

            // Assert that the response status code is 201 (Created)
            Assert.AreEqual(201, (int)response.StatusCode);
        }
    }
}