﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace magda.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
            }
         
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}