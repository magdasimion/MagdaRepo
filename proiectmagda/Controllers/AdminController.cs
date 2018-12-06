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
            return View();
        }
        // GET: Admin
        public ActionResult Tabel()

        {
            return View();
        }

        // GET: Admin
        public ActionResult List()
        

        {
            var nume1 = "Andrei";
            var nume2 = "Andreea";
            var nume3 = "Alexandru";
            var nume4 = "Alexandra";
            var nume5 = "Mirabelia";
            ViewBag.a = nume1;
            ViewBag.b = nume2;
            ViewBag.c = nume3;
            ViewBag.d = nume4;
            ViewBag.e = nume5;

            var today = DateTime.Now;
            ViewBag.f = today;

            var greeting = "Welcome";
            ViewBag.g = greeting;

            var counter = 103;
            ViewBag.h = counter;
            return View();
        }
        
        // GET: Admin
        public ActionResult Details()

        {
            var nume1 = "Ion";
            var nume2 = "Maria";
            var nume3 = "Silvia";
            var nume4 = "Ioana";
            var nume5 = "Crina";
            ViewBag.a = nume1;
            ViewBag.b = nume2;
            ViewBag.c = nume3;
            ViewBag.d = nume4;
            ViewBag.e = nume5;
            return View();
        }
    }


}