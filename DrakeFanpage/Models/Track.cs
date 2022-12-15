namespace DrakeFanpage.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Composer { get; set; }
        public int Seconds { get; set; }
        public DateTime ReleaseDate { get; set; }


        //Relations
        public Album Album { get; set; }
        public Album AlbumID { get; set; }
        public TrackReview TrackReview { get; set; }
        public MediaType MediaType { get; set; }

    }
}
