﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proiectmagda.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        // GET: Employee
        public ActionResult Tabel()
        {
            return View();
        }
        // GET: Admin
        public ActionResult List()

        {

            var produs1 = "Ion";
            var produs2 = "Maria";
            var produs3 = "Vasile";
            ViewBag.a = produs1;
            ViewBag.b = produs2;
            ViewBag.c = produs3;
            return View();
        }
        // GET: Admin
        public ActionResult Details()

        {

            var produs1 = "Coffe";
            var produs2 = "tea";
            var produs3 = "milk";
            ViewBag.a = produs1;
            ViewBag.b = produs2;
            ViewBag.c = produs3;

            return View();
        }
        
    }
}