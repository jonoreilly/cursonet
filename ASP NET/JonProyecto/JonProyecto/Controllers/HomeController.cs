using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JonProyecto.Models;

namespace JonProyecto.Controllers
{
    public class HomeController : Controller
    {
        AnunciolandiaEntities context = new AnunciolandiaEntities();


        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Test(string value)
        {
            ViewBag.Test = value;
            return View("Test");
        }
    }
}