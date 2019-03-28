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

        // GET: Film/Details/5
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

        // GET: Film/Create
        public ActionResult Create()
        {
            return View();
        }

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

        // GET: Details/id

        public ActionResult SelectedDetails(int? id)
        {
            if (id == null) return new HttpNotFoundResult();

            Film selectedFilm = films.First(p => p.FilmID == id);

            if (selectedFilm == null) return new HttpNotFoundResult();


            //User user = new User
            //{
            //    UserID = 1,
            //    FirstName = "Rob",
            //    LastName = "Smith"
            //};

            //UserFilmViewModel viewModel = new UserFilmViewModel
            //{
            //    User = user,
            //    Film = selectedFilm
            //};

            return View(selectedFilm);

        }

        private List<Film> films = new List<Film>()
        {
            new Film { FilmID = 1,

                Name = "Aquaman",
                Description = "Arthur Curry, the human-born heir to the underwater kingdom of Atlantis, goes on a quest to prevent a war between the worlds of ocean and land.",
                FilmLength = "2h 22m",
                GenreID = 1,
                Rating = "5 Stars"},

            new Film { FilmID = 2,

                Name = "The Lord of the Ring",
                Description = "A young Hobbit known as Frodo has been thrown on an amazing adventure, when he is appointed the job of destroying the one ring which was created by the dark lord Sauron. He is assigned with three warriors including Gandelf, Aragorn and Boromir. But it's not going to be an easy journey for the Fellowship of the Ring, on the ultimate quest to rid the Middle-Earth of all evil!",
                FilmLength = "2h 30m",
                GenreID = 2,
                Rating = "5 Stars"},

            new Film { FilmID = 3,

                Name = "Avatar",
                Description = "A paraplegic marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
                FilmLength = "2h 30m",
                GenreID = 3,
                Rating = "4 Stars" },

            new Film { FilmID = 4,

                Name = "The Shape of Water",
                Description = "At a top secret research facility in the 1960s, a lonely janitor forms a unique relationship with an amphibious creature that is being held in captivity.",
                FilmLength = "2h 19m",
                GenreID = 4,
                Rating = "4.5 Stars" },

             new Film { FilmID = 5,

                Name = "Gravity",
                Description = "Two astronauts work together to survive after an accident leaves them stranded in space.",
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
                    Description = "Ryan Bingham enjoys living out of a suitcase for his job, travelling around the country firing people, but finds that lifestyle threatened by the presence of a potential love interest, and a new hire.",
                    FilmLength = "2h 30m",
                    GenreID  = 7,
                    Rating = "4 Stars" },

                 new Film { FilmID = 8,
                     Name = "Before Sunset",
                     Description = "Nine years after Jesse and Celine first met, they encounter each other again on the French leg of Jesse's book tour.",
                     FilmLength = "1h 20m",
                     GenreID = 3,
                     Rating = "5 Stars" },

                 new Film { FilmID = 9,
                     Name = "Cinderella",
                     Description = "When her father unexpectedly dies, young Ella finds herself at the mercy of her cruel stepmother and her scheming stepsisters. Never one to give up hope, Ella's fortunes begin to change after meeting a dashing stranger.",
                     FilmLength = "1h 59m",
                     GenreID = 9,
                     Rating = "4.5 Stars" },

                 new Film { FilmID = 10,
                     Name = "The Mask of Zorro",
                     Description = "A young thief, seeking revenge for the death of his brother, is trained by the once great, but aged Zorro, who also pursues vengeance of his own.",
                     FilmLength = "1h 45m",
                     GenreID = 1,
                     Rating = "5 Stars" },
                 //
            };
    }
}
