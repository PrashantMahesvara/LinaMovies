using AutoMapper;
using LinaMovies.Web.Dto;
using LinaMovies.Web.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace LinaMovies.Web.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
     
        public IHttpActionResult GetMovies()
        {
            var movieDtos = _db.Movies
                .Include(g => g.Genre)
                .Include(f => f.Format)
                .ToList();

            return Ok(movieDtos);
        }
   
        public MovieDto GetMovie(int id)
        {
            var movie = _db.Movies.Include(g => g.Genre).Include(f => f.Format).Single(c => c.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Movie, MovieDto>(movie);
        }

        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _db.Movies.Add(movie);
            _db.SaveChanges();

            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _db.Movies.Include(g => g.Genre).Include(f => f.Format).Single(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(movieDto, movieInDb);

            _db.SaveChanges();
        }

        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movieInDb = _db.Movies
                .Include(g => g.Genre)
                 .Include(f => f.Format)
                  .Single(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _db.Movies.Remove(movieInDb);
            _db.SaveChanges();
        }
    }
}
