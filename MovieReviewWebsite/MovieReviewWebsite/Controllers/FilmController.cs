using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieReviewWebsite.Models;

namespace MovieReviewWebsite.Controllers
{
    public class FilmController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: Film
        public ActionResult Index()
        {
            return View(db.Films.ToList());
        }

        //GET: Film/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);

        }


        // GET: Details/id

        public ActionResult SelectedDetails(int? id)
        {
            if (id == null) return new HttpNotFoundResult();

            Film selectedFilm = films.First(p => p.FilmID == id);

            if (selectedFilm == null) return new HttpNotFoundResult();


            User user = new User
            {
                UserID = 1,
                FirstName = "Rob",
                LastName = "Smith"
            };

            UserFilmViewModel viewModel = new UserFilmViewModel
            {
                User = user,
                Film = selectedFilm
            };

            return View(selectedFilm);

        }

        // GET: Film/Create
        public ActionResult Create()
        {
            return View();
        }

        //public ActionResult Index()
        //{
        //    return View(films);
        //}

        // POST: Film/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmID,Name,Description,FilmLength,Genre,Rating")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(film);
        }

        // GET: Film/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
        ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", film.GenreID);
            return View(film);
        }
        

        // POST: Film/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmID,Name,Description,FilmLength,Genre,Rating")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        // GET: Film/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Film/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
            


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private List<Film> films = new List<Film>()
        {
            new Film { FilmID = 1,

                Name = "Aquaman",
                Description = "Aquaman is a film",
                FilmLength = "2h 22m",
                GenreID = 1,
                Rating = "5 Stars"},

            new Film { FilmID = 2,

                Name = "The Lord of the Ring",
                Description = "The Lord of the Ring is a film",
                FilmLength = "2h 30m",
                GenreID = 2,
                Rating = "5 Stars"},

            new Film { FilmID = 3,

                Name = "Avatar",
                Description = "Avatar is a film",
                FilmLength = "2h 30m",
                GenreID = 3,
                Rating = "4 Stars" },

            new Film { FilmID = 4,

                Name = "The Shape of Water",
                Description = "The Shape of Water is a film",
                FilmLength = "2h 19m",
                GenreID = 4,
                Rating = "4.5 Stars" },

             new Film { FilmID = 5,

                Name = "Gravity",
                Description = "Gravity is a film",
                FilmLength = "1h 45m",
                GenreID = 5,
                Rating = "5 Stars" },

                new Film { FilmID = 6,

                Name = "Up in the Air",
                Description = "Up in the Air is a film",
                FilmLength = "2h 15m",
                GenreID = 6,
                Rating = "4 Stars" },

                new Film { FilmID = 7,
                    Name = "Their Finest",
                    Description = "Their Finest is a film",
                    FilmLength = "2h 30m",
                    GenreID  = 7,
                    Rating = "4 Stars" },

                 new Film { FilmID = 8,
                     Name = "Before Sunset",
                     Description = "Before Sunset is a film",
                     FilmLength = "1h 20m",
                     GenreID = 3,
                     Rating = "5 Stars" },

                 new Film { FilmID = 9,
                     Name = "Cinderella",
                     Description = "Cinderella is a film",
                     FilmLength = "1h 59m",
                     GenreID = 9,
                     Rating = "4.5 Stars" },

                 new Film { FilmID = 10,
                     Name = "The Mask of Zorro",
                     Description = "The Mask of Zorro is a film",
                     FilmLength = "1h 45m",
                     GenreID = 1,
                     Rating = "5 Stars" },
           
            };

        }
}


         



