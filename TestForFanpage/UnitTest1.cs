//using System.Net;
//using System.Net.Http;
//using System.Text;
//using DrakeFanpage.Data;
//using DrakeFanpage.Models;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using NUnit.Framework;

//namespace MyWebApi.Tests
//{
//    public class AlbumControllerTests
//    {
//        [OneTimeSetUp]
//        public void OneTimeSetup()
//        {
//            using FanpageContext db = new();
//            db.Database.EnsureDeleted();
//            //db.Database.Migrate();
//            // NOTE: Instead of Migrate(), above, could use EnsureCreated().
//            //       But Migrate() is better as long as we have the migration data:
//            //       EnsureCreated() won't let us add more migrations later.
//            db.Database.EnsureCreated();
//        }

//        private readonly FanpageContext _dbContext;

//        public AlbumControllerTests(FanpageContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        [Test]
//        public async Task TestPost()
//        {
//            // Arrange
//            var client = new HttpClient();
//            Album album = new Album
//            {
//                Title = "Test album",
//                ReleaseDate = DateTime.Now,
//            };

//            var content = new StringContent(JsonConvert.SerializeObject(album), Encoding.UTF8, "application/json");
//            // Act
//            var response = await client.PostAsync("http://localhost:5000/api/albums", content);
//            // Assert
//            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
//            var savedAlbum = await _dbContext.Albums.FirstOrDefaultAsync(a => a.Title == album.Title);
//            Assert.NotNull(savedAlbum);
//            Assert.AreEqual(album.ReleaseDate, savedAlbum.ReleaseDate);
//        }
//    }
//}



////using System.Net;
////using System.Text;
////using DrakeFanpage.Models;
////using Newtonsoft.Json;
////using NUnit.Framework.Interfaces;
////using NUnit.Framework.Internal;

////namespace MyWebApi.Tests
////{
////    public class AlbumControllerTests : TestFixture
////    {
////        public AlbumControllerTests(ITypeInfo fixtureType, object?[]? arguments = null) : base(fixtureType, arguments)
////        {
////        }

////        [Test]
////        public async Task TestPost()
////        {
////            // Arrange
////            var client = new HttpClient(); Album album = new()
////            {
////                Title = "Test album",
////                ReleaseDate = DateTime.Now,
////            };

////            var content = new StringContent(JsonConvert.SerializeObject(album), Encoding.UTF8, "application/json");
////            // Act

////            var response = await client.PostAsync("http://localhost:5000/api/albums", content);
////            // Assert

////            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
////        }
////    }

////}
