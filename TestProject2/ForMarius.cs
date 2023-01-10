//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestProject2
//{
//    using DrakeFanpage.Models;
//    using NUnit.Framework;

//    [TestFixture]
//    public class TrackTests
//    {
//        [Test]
//        public void Track_Properties_ShouldHaveCorrectValues()
//        {
//            // Arrange
//            var track = new Track
//            {
//                Id = 1,
//                Title = "My Title",
//                Duration = 180,
//                MusicianId = 5,
//                Composer = new Musician
//                {
//                    Id = 5,
//                    FirstName = "John",
//                    LastName = "Doe"
//                },
//                AlbumTracks = new List<Album_Track>
//            {
//                new Album_Track { Id = 1, AlbumId = 2, TrackId = 1 },
//                new Album_Track { Id = 2, AlbumId = 3, TrackId = 1 }
//            }
//            };

//            // Assert
//            Assert.AreEqual(1, track.Id);
//            Assert.AreEqual("My Title", track.Title);
//            Assert.AreEqual(180, track.Duration);
//            Assert.AreEqual(5, track.MusicianId);
//            Assert.AreEqual("John", track.Composer.FirstName);
//            Assert.AreEqual("Doe", track.Composer.LastName);
//            Assert.AreEqual(2, track.AlbumTracks.Count);
//            Assert.AreEqual(1, track.AlbumTracks[0].Id);
//            Assert.AreEqual(2, track.AlbumTracks[0].AlbumId);
//            Assert.AreEqual(1, track.AlbumTracks[0].TrackId);
//            Assert.AreEqual(2, track.AlbumTracks[1].Id);
//            Assert.AreEqual(3, track.AlbumTracks[1].AlbumId);
//            Assert.AreEqual(1, track.AlbumTracks[1].TrackId);
//        }

//        [Test]
//        public void Duration_should_nullable()
//        {
//            //Arrange
//            var track = new Track();
//            //Assert
//            Assert.IsNull(track.Duration);
//        }

//        [Test]
//        public void MusicianId_should_nullable()
//        {
//            //Arrange
//            var track = new Track();
//            //Assert
//            Assert.IsNull(track.MusicianId);
//        }

//        [Test]
//        public void Composer_should_nullable()
//        {
//            //Arrange
//            var track = new Track();
//            //Assert
//            Assert.IsNull(track.Composer);
//        }
//        [Test]
//        public void AlbumTracks_should_nullable()
//        {
//            //Arrange
//            var track = new Track();
//            //Assert
//            Assert.IsNull(track.AlbumTracks);
//        }
//    }

//}
