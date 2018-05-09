using LinaMovies.Web.Models;
using LinaMovies.Web.ViewModels.Film;
using System.Linq;
using System.Web.Mvc;   

namespace LinaMovies.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var viewModel = new MovieViewModel
            {
                MovieCount = _db.Movies.Count()
            };

            return View(viewModel);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}