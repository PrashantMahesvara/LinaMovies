using System.ComponentModel.DataAnnotations;

namespace LinaMovies.Web.Models
{
    public class Format
    {
        [Key]
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}