using System.Net;
using System.Net.Http;
using System.Text;
using DrakeFanpage.Data;
using DrakeFanpage.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NUnit.Framework;

namespace TestProject2
{
    [TestFixture]
    public class AlbumTests
    {
        [Test]
        public void Album_SetsTitle()
        {
            // Arrange
            var title = "Test album";

            // Act
            var album = new Album { Title = title };

            // Assert
            Assert.AreEqual(title, album.Title);
        }

        //[Test]
        //public void Album_SetsReleaseDate()
        //{
        //    // Arrange
        //    var releaseDate = new string(2020, 1, 1);

        //    // Act
        //    var album = new Album { ReleaseDate = releaseDate };

        //    // Assert
        //    Assert.AreEqual(releaseDate, album.ReleaseDate);
        //}



    }

    [TestFixture]
    public class AlbumReviewTests
    {
        [Test]
        public void AlbumReview_SetsName()
        {
            // Arrange
            var name = "John Doe";

            // Act
            var review = new AlbumReview { Name = name };

            // Assert
            Assert.AreEqual(name, review.Name);
        }

        [Test]
        public void AlbumReview_SetsCreatedDate()
        {
            // Arrange
            var createdDate = new DateTime(2020, 1, 1);

            // Act
            var review = new AlbumReview { CreatedDate = createdDate };

            // Assert
            Assert.AreEqual(createdDate, review.CreatedDate);
        }

        [Test]
        public void AlbumReview_SetsComment()
        {
            // Arrange
            var comment = "Great album";

            // Act
            var review = new AlbumReview { Comment = comment };

            // Assert
            Assert.AreEqual(comment, review.Comment);
        }

        [Test]
        public void AlbumReview_SetsRating()
        {
            // Arrange
            var rating = 5;

            // Act
            var review = new AlbumReview { Rating = rating };

            // Assert
            Assert.AreEqual(rating, review.Rating);
        }

        [Test]
        public void AlbumReview_SetsAlbum()
        {
            // Arrange
            var album = new List<Album> { new Album { Title = "Test album" } };

            // Act
            var review = new AlbumReview { Album = album };

            // Assert
            Assert.AreEqual(album, review.Album);
        }

    }


}