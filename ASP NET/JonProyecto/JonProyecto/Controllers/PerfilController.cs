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
        AnunciolandiaEntities context = new AnunciolandiaEntities();

        // GET: Perfil
        public ActionResult LogIn()
        {
            return View("LogIn");
        }

        [HttpPost]
        public ActionResult LogInAction (FormCollection formData)
        {
            Response.Cookies["userName"].Value = formData["username"];
            return RedirectToAction("../Home/Test", new { value = formData["username"].ToString() });
            //return HomeIndex();
        }


        public ActionResult Registrarse ()
        {
            return View("Registrarse");
        }

        [HttpPost]
        public ActionResult RegistrarseAction(FormCollection formData)
        {
            if (context.User.Any(row => row.Nombre == formData["username"]))
            {
                ViewBag.Error = "Ese usuario ya existe";
                return View("Registrarse");
            }
            User usuario = new User();
            usuario.Nombre = formData["username"];
            usuario.Contraseña = formData["password"];
            usuario.RolId = 0;

            Response.Cookies["userName"].Value = context.User.
            return HomeIndex();
        }


        public ActionResult LogOut()
        {
            return HomeIndex();
        }


        public ActionResult EliminarCuenta()
        {
            return HomeIndex();
        }


        public ActionResult HomeIndex()
        {
            return RedirectToAction("../Home/Index");
        }
    }
}