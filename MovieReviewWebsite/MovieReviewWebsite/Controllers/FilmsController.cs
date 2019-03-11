using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieReviewWebsite.Controllers
{
    public class FilmsController : Controller
    {
        // GET: Films
        public string Index()
        {
            return "Films index";
        }

        public string Film()
        {
            return "Films Page"; 
        }
    }
}