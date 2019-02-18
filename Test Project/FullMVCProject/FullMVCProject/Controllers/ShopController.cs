using FullMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullMVCProject.Controllers
{

    public class ShopController : Controller
    {
        private ProductModel _model;
        public ShopController() { }
        public ShopController(ProductModel model)
        {
            _model = model;
        }

        // GET: Shop
        public ViewResult Index()
        {
            // code for the Index Action Method will go here	
            ViewBag.Title = "The shop";
            ViewData["CurrentTime"] = DateTime.Now;
            ViewBag.WelcomeMessage = "Welcome to the shop. Kindly spend all your money!";
            return View();

        }

        public ViewResult Product()
        {
            if (_model == null)
            {
                _model = new ProductModel();
                _model.Name = "IPhone 6";
                _model.Description = "Better than the IPhone 5 etc";
                _model.Price = 399.99M;
            }
            if (_model.Price > 200)
            {
                ViewBag.SubTitle = "Bling!";
            }
            else
            {
                ViewBag.SubTitle = "Cheap and nasty product!";
            }
            return View(_model);
        }

        public RedirectResult DVD()
        {
            return RedirectPermanent("~/Shop/Product");
        }
    }
}