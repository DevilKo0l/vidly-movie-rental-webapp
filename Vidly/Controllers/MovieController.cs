using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name="Shrek"},
                new Movie {Id = 2, Name = "Interstellar"},
                new Movie {Id = 3, Name = "Spirited Away"},
                new Movie {Id = 4, Name = "The Godfather"},
                new Movie {Id = 5, Name = "The Matrix"}
            };
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}