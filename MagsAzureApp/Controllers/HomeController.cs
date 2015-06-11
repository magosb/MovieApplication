using MagsAzureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MagsAzureApp.Controllers
{
    public class HomeController : Controller
    {
        private AzureMoviesDBContext db = new AzureMoviesDBContext();

        [AllowAnonymous]
        public ActionResult Index()
        {
            decimal smallest = 5;

            var movies = from m in db.Movies
                         select m;
            movies = movies.Where(x => x.Rating == smallest);

            return View(movies);
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "About MagsMovies";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: MoviesTest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Create([Bind(Include = "ID,Title,Producer,ReleaseDate,Genre,Image,Rating,ImagePath,TrailerPath")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}