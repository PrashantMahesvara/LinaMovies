using LinaMovies.Web.Models;
using System.Collections.Generic;

namespace LinaMovies.Web.ViewModels.Film
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Format> Formats { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public Movie Movie { get; set; }
        public int MovieCount { get; set; }
    }
}