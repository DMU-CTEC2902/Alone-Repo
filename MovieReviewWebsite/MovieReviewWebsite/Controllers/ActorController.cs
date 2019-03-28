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
    public class ActorController : Controller
    {
        private ActorContext db = new ActorContext();
        // GET: Actor
        public ActionResult Index()
        {
            //return View();
            return View(db.Actor.ToList());
        }

        // GET: Actors/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actor.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // GET: Film/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ActorID,ActorName,Description")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Actor.Add(actor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actor);
        }

        // GET: Details/id

        public ActionResult SelectedDetails(int? id)
        {
            if (id == null) return new HttpNotFoundResult();

            Actor selectedActor = actor.First(p => p.ActorID == id);

            if (selectedActor == null) return new HttpNotFoundResult();

            return View(selectedActor);

        }

        private List<Actor> actor = new List<Actor>()
        {
            new Actor { ActorID = 1,

                ActorName = "Tom",
                Description = "bla bla bla"},

            new Actor { ActorID = 2,

                ActorName = "Mike",
                Description = "bla bla bla"},

            new Actor { ActorID = 3,

                ActorName = "Sam",
                Description = "bla bla bla"},
            };
        //private object db;
    }
}