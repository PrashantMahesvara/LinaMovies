using LinaMovies.Web.Models;
using System.Collections.Generic;

namespace LinaMovies.Web.ViewModels.Film
{
    public class EditMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Format> Formats { get; set; }
        public Movie Movie { get; set; }
    }
}