using System.ComponentModel.DataAnnotations;

namespace DrakeFanpage.Models
{
    public class Album
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Album title")]
        [Required(ErrorMessage = "Album title is required.")]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "Album title must be between 1 and 250 characters..")]
        public string Title { get; set; }

        [Display(Name = "Release date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }
        

        // Relations
        public List<Artist> Artists { get; set; }
        public List<Track> Tracks { get; set; }
        public AlbumReview? AlbumReview { get; set; }
        public Photo? Photo { get; set; }
    }

    // ToDo: Add Constructors?
}
