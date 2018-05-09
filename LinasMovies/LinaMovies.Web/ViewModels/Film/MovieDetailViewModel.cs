using LinaMovies.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinaMovies.Web.ViewModels.Film
{
    public class MovieDetailViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}