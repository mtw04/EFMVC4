using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using EFMVC4.Models;
using System.Data;
using System.Data.Entity;

namespace EFMVC4.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDBEntities db = new MoviesDBEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<Movie> Movies = db.Movies.ToList();
            return View(Movies);
        }

        // GET: /Details/1

        public ActionResult Details(int id = 0)
        {
            Movie movie = db.Movies.Single(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: /Create

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Create

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.AddObject(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        //
        // GET: /Edit/5

        [HttpGet] // Not necessary since it's the default
        public ActionResult Edit(int id = 0)
        {
            Movie movie = db.Movies.Single(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Attach(movie);
                db.ObjectStateManager.ChangeObjectState(movie, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        //
        // GET: /Delete/5

        public ActionResult Delete(int id = 0)
        {
            Movie movie = db.Movies.Single(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Single(m => m.Id == id);
            db.Movies.DeleteObject(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Dispose method

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
