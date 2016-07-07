using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCMoviesSB.Models;

namespace MVCMoviesSB.Controllers
{
    public class HomeController : Controller
    {
        private MoviesShivEntities db = new MoviesShivEntities();
        // GET: Home
        public ActionResult Index()
        {
            //Linq query to return all movies from the database
            var movies = from m in db.Movies
                         select m;


            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            Movie movie = db.Movies.Find(id);

            return View(movie);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Movie movie = db.Movies.Find(id);

            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
           

            // get the edited data
            db.Entry(movie).State = EntityState.Modified;

            // save changes to db
            db.SaveChanges();

            // go back to Index action method
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Movie movie = db.Movies.Find(id);

            return View(movie);
        }

        [HttpPost , ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie =  db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();

            // go back to Index action method
            return RedirectToAction("Index");
        }
    }

   
}