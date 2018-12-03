using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proiectmagda.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()

        {
            var nume1 = "Andrei";
            var nume2 = "Andreea";
            var nume3 = "Alexandru";
            var nume4 = "Alexandra";
            var nume5 = "Mirabelia";
            ViewBag.Title = nume1;
            ViewBag.All = nume2;
        
            return View();
        }
        // GET: Admin
        public ActionResult List()

        {
            return View();
        }
    }


}