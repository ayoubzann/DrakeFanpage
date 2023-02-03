using DrakeFanpage.Models;
using Microsoft.EntityFrameworkCore;

namespace DrakeFanpage.Data
{
    public class FanpageContext : DbContext
    {
        public FanpageContext()
        {
        }

        public FanpageContext(DbContextOptions<FanpageContext> options) : base(options) { }


        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumReview> AlbumReviews { get; set; }
        public DbSet<Artist> Artists {get; set;}
        public DbSet<Track> Tracks {get; set;}
        public DbSet<TrackReview> TrackReviews {get; set;}


    }
}
