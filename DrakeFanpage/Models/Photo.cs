using System.ComponentModel.DataAnnotations;

namespace DrakeFanpage.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PhotoURL { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;

        // Relations

        public Album? Album { get; set; }
        public Track? Track { get; set; }

    }
}

// ToDo: Figure out blob-storage
