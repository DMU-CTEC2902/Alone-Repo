//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data;
//using System.Net;
//using System.Data.Entity;
//using System.Web.Mvc;
//using MovieReviewWebsite.Models;

//namespace MovieReviewWebsite.Controllers
//{
//    public class DirectorController : Controller
//    {
//        private DirectorContext db = new DirectorContext();
//        // GET: Director
//        public ActionResult Index()
//        {
//            //return View();
//            return View(db.Director.ToList());
//        }
//        // GET: Director/Details
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Director director = db.Director.Find(id);
//            if (director == null)
//            {
//                return HttpNotFound();
//            }
//            return View(director);
//        }

//        // GET: Film/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Actor/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "DirectorID,DirectorName,Description")] Director director)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Director.Add(director);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(director);
//        }

//        // GET: Details/id

//        public ActionResult SelectedDetails(int? id)
//        {
//            if (id == null) return new HttpNotFoundResult();

//            Director selectedDirector = director.First(p => p.DirectorID == id);

//            if (selectedDirector == null) return new HttpNotFoundResult();

//            return View(selectedDirector);

//        }

//        private List<Director> actor = new List<Director>()
//        {
//            new Director { DirectorID = 1,

//                DirectorName = "David",
//                Description = "bla bla bla"},

//            new Director { DirectorID = 2,

//                DirectorName = "Amina",
//                Description = "bla bla bla"},

//            new Director { DirectorID = 3,

//                DirectorName = "Lilly",
//                Description = "bla bla bla"},
//        };
//    }
//}