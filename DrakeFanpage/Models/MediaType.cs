using System.ComponentModel.DataAnnotations;

namespace DrakeFanpage.Models
{
    public class MediaType
    {
        [Key]   
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        // Relations

        public Album Album { get; set; }

        public Track Track { get; set; }
    }
}
