namespace DrakeFanpage.Models
{
    public class MediaType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        // Relations

        public Album Album { get; set; }

        public Track Track { get; set; }
    }
}
