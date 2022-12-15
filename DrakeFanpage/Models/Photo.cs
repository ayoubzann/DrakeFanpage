namespace DrakeFanpage.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoURL { get; set; }
        public string Name { get; set; }

        // Relations

        public Album Album { get; set; }
        public Track Track { get; set; }

    }
}

// ToDo: Figure out blob-storage
