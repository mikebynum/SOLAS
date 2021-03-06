﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOLAS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Adopt()
        {
            ViewBag.Message = "Your adoptions page.";

            return View();
        }

        public ActionResult Donate()
        {
            ViewBag.Message = "Your donations page.";

            return View();
        }

        public ActionResult Foster()
        {
            ViewBag.Message = "Your foster page.";

            return View();
        }

        public ActionResult Cat_Of_The_Month()
        {
            ViewBag.Message = "Your Cat of the Month page.";

            return View();
        }

    }
}