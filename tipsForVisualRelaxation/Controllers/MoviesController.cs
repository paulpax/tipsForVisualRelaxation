using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tipsForVisualRelaxation.Models;
using tipsForVisualRelaxation.ViewModels;
using System.Data.Entity;
using tipsForVisualRelaxation.DataAccessLayer;

namespace tipsForVisualRelaxation.Controllers
{
    public class MoviesController : Controller
    {
        private MovieContext db;

        public MoviesController()
        {
            db = new MovieContext();
        }

        public ActionResult New()
        {
            var genres = db.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = db.Movies.SingleOrDefault(c => c.ID == id);

            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = db.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = db.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }
            if (movie.ID == 0)
            {
                db.Movies.Add(movie);
            }
            else
            {
                var movieInDb = db.Movies.Single(m => m.ID == movie.ID);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            db.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }


        // GET: Movies
        public ViewResult Index()
        {
            var movies = db.Movies.Include(m => m.Genre).ToList();


            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = db.Movies.Include(m => m.Genre).SingleOrDefault(m => m.ID == id);

            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }

    }

}