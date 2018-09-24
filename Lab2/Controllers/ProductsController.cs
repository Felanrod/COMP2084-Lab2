using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Details/Product-Name
        public ActionResult Details(string ProductName)
        {
            ViewBag.Details = "You selected product: " + ProductName;
            return View();
        }
    }
}