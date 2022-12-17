namespace DrakeFanpage.Models
{
    public class TrackReview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        //Relations

        public Track Track { get; set; }
    }
}
