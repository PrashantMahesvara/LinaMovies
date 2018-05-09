using LinaMovies.Web.Models;
using LinaMovies.Web.ViewModels.Film;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace LinaMovies.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        [HttpGet]
        public ViewResult Index()
        {
            if (User.IsInRole(("Admin")))
                return View("Index");
            else
                return View("UserIndex");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var genreTypes = _db.Genres.ToList();
            var formatTypes = _db.Formats.ToList();

            var viewModel = new NewMovieViewModel
            {
                Movie = new Movie(),
                Genres = genreTypes,
                Formats = formatTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");
        }

        public ActionResult Details(int? id)
        {
            var movie = _db.Movies.Include(g => g.Genre).SingleOrDefault(m => m.Id == id);
            var genreTypes = _db.Genres.ToList();
            var formatTypes = _db.Formats.ToList();

            if (movie == null)
                return HttpNotFound();

            var viewModel = new EditMovieViewModel
            {
                Movie = movie,
                Genres = genreTypes,
                Formats = formatTypes
            };

            if (User.IsInRole("Admin"))
            {
                return View("Details", viewModel);
            }
            else
            {
                return View("ReadOnlyDetail", viewModel);
            }
        }

        public ActionResult Edit(int id)
        {
            var movie = _db.Movies.Include(g => g.Genre).SingleOrDefault(m => m.Id == id);
            var genreTypes = _db.Genres.ToList();
            var formatTypes = _db.Formats.ToList();

            if (movie == null)
                return HttpNotFound();

            var viewModel = new EditMovieViewModel
            {
                Movie = movie,
                Genres = genreTypes,
                Formats = formatTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(movie).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var movie = _db.Movies.Include(g => g.Genre).SingleOrDefault(m => m.Id == id);
            var genreTypes = _db.Genres.ToList();
            var formatTypes = _db.Formats.ToList();

            var viewModel = new EditMovieViewModel
            {
                Movie = movie,
                Genres = genreTypes,
                Formats = formatTypes
            };

            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
                return HttpNotFound();

            Movie movie = _db.Movies.Find(id);

            _db.Movies.Remove(movie);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}