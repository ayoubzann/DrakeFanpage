namespace DrakeFanpage.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }
        

        // Relations
        public Artist Artist { get; set; }
        public MediaType MediaType { get; set; }
        public AlbumReview AlbumReview { get; set; }
        public Photo Photo { get; set; }



    }

    // ToDo: Add Constructors?
}
