using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JonProyecto.Models;

namespace JonProyecto.Controllers
{
    AnunciolandiaEntities context = new AnunciolandiaEntities();

    public class HomeController : Controller
    {
        AnunciolandiaEntities context = new AnunciolandiaEntities();

        public ActionResult Index(object usuario)
        {
            if (usuario == null)
            {
                usuario = new 
            }

            return View("Index", usuario);
        }


        public ActionResult 
    }
}