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
            if (string.IsNullOrWhiteSpace(formData["username"]) || !formData["username"].All(char.IsLetterOrDigit))
            {
                ViewBag.Error = "Nombre de usuario invalido";
                return View("LogIn");
            }
            

            if (!context.User.Any(row => row.Nombre == formData["username"]))
            {
                ViewBag.Error = "Ese usuario no existe";
                return View("LogIn");
            }

            ViewBag.Error = null;

            return HomeIndex();
        }


        public ActionResult Registrarse ()
        {
            return View("Registrarse");
        }

        [HttpPost]
        public ActionResult RegistrarseAction(FormCollection formData)
        {
            if (string.IsNullOrWhiteSpace(formData["username"]) || !formData["username"].All(char.IsLetterOrDigit))
            {
                ViewBag.Error = "Nombre de usuario invalido";
                return View("Registrarse");
            }

            if (string.IsNullOrWhiteSpace(formData["password"]) || !formData["password"].All(char.IsLetterOrDigit))
            {
                ViewBag.Error = "Contraseña invalida";
                return View("Registrarse");
            }

            if (context.User.Any(row => row.Nombre == formData["username"]))
            {
                ViewBag.Error = "Ese usuario ya existe";
                return View("Registrarse");
            }

            ViewBag.Error = null;

            User usuario = new User();
            usuario.Nombre = formData["username"];
            usuario.Contraseña = formData["username"];
            usuario.RolId = 0;

            Response.Cookies["userName"].Value = formData["username"];
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