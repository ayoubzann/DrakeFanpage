namespace DrakeFanpage.Models
{
    public class Artist
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        //Relations

        public List<Album> Albums { get; set; }
    }
}
