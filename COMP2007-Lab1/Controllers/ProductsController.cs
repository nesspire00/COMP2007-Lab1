using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Details
        public ActionResult Details(string Product)
        {
            ViewBag.Message = "You selected product: " + Product;
            return View();
        }
    }
}