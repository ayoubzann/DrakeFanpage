//using System.Net;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using DrakeFanpage.Models;
//using Newtonsoft.Json;
//using NUnit.Framework;
//using NUnit.Framework.Internal;

//namespace MyWebApi.Tests
//{
//    public class AlbumsControllerTests : TestFixture
//    {
//        [Test]
//        public async Task TestPost()
//        {
//            // Arrange
//            var client = new HttpClient();
//            var album = new Album { Title = "Test Album", Artist = "Test Artist" };
//            var content = new StringContent(JsonConvert.SerializeObject(album), Encoding.UTF8, "application/json");

//            // Act
//            var response = await client.PostAsync("http://localhost:5000/api/albums", content);
//            var result = await response.Content.ReadAsAsync<Album>();

//            // Assert
//            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
//            Assert.AreEqual("Test Album", result.Title);
//            Assert.AreEqual("Test Artist", result.Artist);
//        }
//    }
//}
