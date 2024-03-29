﻿using TextBox_Validation_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TextBox_Validation_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var appInfo = new AppInformation();
            ViewBag.Message = appInfo;
            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonModel person)
        {
            
            return View(); // Examine with breakpoint
        }
    }
}