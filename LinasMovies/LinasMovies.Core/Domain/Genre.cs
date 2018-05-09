using System.ComponentModel.DataAnnotations;

namespace LinaMovies.Web.Models
{
    public class Genre
    {
        [Key]
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}