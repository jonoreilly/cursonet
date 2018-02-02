using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JonProyecto.Models;

namespace JonProyecto.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult LogIn(object usuario)
        {
            return View("LogIn", usuario);
        }

        public ActionResult LogInAction (object usuario)
        {
            return HomeIndex(usuario);
        }


        public ActionResult Registrarse (object usuario)
        {
            return View("Registrarse", usuario);
        }

        public ActionResult RegistrarseAction(object usuario)
        {
            return HomeIndex(usuario);
        }


        public ActionResult LogOut(object usuario)
        {
            return HomeIndex(usuario);
        }


        public ActionResult EliminarCuenta(object usuario)
        {
            return HomeIndex(usuario);
        }


        public ActionResult HomeIndex(object usuario)
        {
            return RedirectToAction("../Home/Index", usuario);
        }
    }
}