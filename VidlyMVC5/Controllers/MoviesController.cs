using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC5.Models;

namespace VidlyMVC5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult MovieList()
        {
            var movies = new List<Movie> ()
            {
                new Movie() { Name = "Shark" },
                new Movie() { Name = "StarWar" }
            };
            return View(movies);
        }
    }
}