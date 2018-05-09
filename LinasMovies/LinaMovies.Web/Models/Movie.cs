using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinaMovies.Web.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Display(Name = "Svensk titel")]
        public string AltTitle { get; set; }

        [Display(Name = "Utgiven")]
        public int Released { get; set; }

        [Display(Name = "Längd (minuter)")]
        public int? RunningTimeInMinutes { get; set; }

        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [Display(Name = "Animerad")]
        public bool Animated { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        [ForeignKey("FormatId")]
        public Format Format { get; set; }
        public byte FormatId { get; set; }
    }
}