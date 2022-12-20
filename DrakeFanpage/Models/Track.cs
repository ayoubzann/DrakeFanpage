using System.ComponentModel.DataAnnotations;

namespace DrakeFanpage.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Song Title")]
        [Required(ErrorMessage = "Song title is required.")]
        [StringLength(250,MinimumLength = 1, ErrorMessage = "The song title must be between 1 and 250 characters.")]
        public string Title { get; set; }

        [Display(Name = "Composer")]
        [Required(ErrorMessage = "Composer(s) must be credited.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Composer(s) must be between 1 and 500 characters..")]
        public string Composer { get; set; }

        [Display(Name = "Song length")]
        [Required(ErrorMessage = "Song length is required, must be stated in number of seconds.")]
        public int Seconds { get; set; }

        [Display(Name = "Release date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }


        //Relations
        public Album Album { get; set; }
        public List<TrackReview> TrackReviews { get; set; }


    }
}
