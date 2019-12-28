using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeCrab.Models;
using WeCrab.ViewModel;

namespace WeCrab.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            var movieModel = getMovies();

            return View(movieModel);
        }

        private IEnumerable<Movie> getMovies()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Totally Spies"},
                new Movie {Id = 2, Name = "Ben 10 Ultimate Alien"}
            };


            return movies;
        }

        public ActionResult Details(int mId)
        {
            var movieId = getMovies().SingleOrDefault(m => m.Id == mId);

            return View(movieId);
        }

        // GET: Movies/Random
        /*public ActionResult Random()
        {
            var movie = new Movie() { Name = "Life with Louie" };

            var categories = new List<Category>
            {
                new Category {Name = "Heniek"},
                new Category {Name = "Barbara"}
            };

            var randomViewModel = new MovieViewModel
            {
                Categories = categories,
                Movie = movie
            };

            return View(randomViewModel);
        }*/


        // W RouteConfig ustawiliśmy jakąś generyczną ścieżke a tutaj ją określamy, ważne jest aby podać dobry adres oraz parametry wraz z ograniczeniami 
        //regex oznacza że określamy ile znaków maksymalnie może przechowywać parametr a po przecinku range określa zakres
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " " + month);
        }

        /*//GET: Movies/Edit/parameter
        public ActionResult Edit(int id)
        {
            return Content("ID " + id);
        }

        //GET: Movies/Index?parameter&parameter
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content("Page index: " + pageIndex + " " + sortBy);
        }*/
    }
}