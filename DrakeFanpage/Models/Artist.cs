using System.ComponentModel.DataAnnotations;

namespace DrakeFanpage.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Artist name")]
        [Required(ErrorMessage = "Artist name is required.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Artists names must be between 1 and 500 characters..")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Artist age is required.")]
        public int Age { get; set; }

        public string? Label { get; set; }


        //Relations

        public List<Album>? Albums { get; set; }
    }
}
