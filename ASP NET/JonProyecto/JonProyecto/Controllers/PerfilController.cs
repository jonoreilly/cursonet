using JonProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JonProyecto.Controllers
{
    public class PerfilController : Controller
    {
        AnunciolandiaEntities context = new AnunciolandiaEntities();


        [AllowAnonymous]
        public ActionResult LogIn()
        {
            return View("LogIn");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogInAction(FormCollection formData)
        {
            string nombre = formData["username"];
            string contraseña = formData["password"];

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(char.IsLetterOrDigit))
            {
                ViewBag.Error = "Nombre de usuario invalido";
                return View("LogIn");
            }


            if (!context.User.Any(row => row.Nombre == nombre))
            {
                ViewBag.Error = "Ese usuario no existe";
                return View("LogIn");
            }


            var usuario = context.User.FirstOrDefault(row => row.Nombre == nombre);

            if (string.IsNullOrWhiteSpace(contraseña) || !contraseña.All(char.IsLetterOrDigit) || usuario.Contraseña != contraseña)
            {
                ViewBag.Error = "Contraseña invalida";
                return View("LogIn");
            }

            ViewBag.Error = null;
            Response.Cookies["userName"].Value = nombre;
            Session["userName"] = nombre;
           

            return HomeIndex();
        }

        [Authorize]
        public ActionResult LogOut()
        {
            Response.Cookies["userName"].Expires = DateTime.Now.AddDays(-1);
            return HomeIndex();
        }

        [AllowAnonymous]
        public ActionResult Registrarse()
        {
            return View("Registrarse");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult RegistrarseAction(FormCollection formData)
        {
            string nombre = formData["userName"];

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(char.IsLetterOrDigit))
            {
                ViewBag.Error = "Nombre de usuario invalido";
                return View("Registrarse");
            }

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(char.IsLetterOrDigit))
            {
                ViewBag.Error = "Contraseña invalida";
                return View("Registrarse");
            }

            if (context.User.Any(row => row.Nombre == nombre))
            {
                ViewBag.Error = "Ese usuario ya existe";
                return View("Registrarse");
            }

            ViewBag.Error = null;

            User usuario = new User();
            usuario.Nombre = nombre;
            usuario.Contraseña = nombre;
            usuario.RolId = 0;
            try
            {
                context.User.Add(usuario);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Response.Cookies["Errores"].Value = e.ToString();
                return RedirectToAction("../Home/test");
            }

            Response.Cookies["userName"].Value = nombre;
          
            return HomeIndex();
        }


        [Authorize]
        public ActionResult VerPerfil(string usuarioPerfil)
        {
            if (usuarioPerfil == "Guest")
            {
                return HomeIndex();
            }

            return View("VerPerfil", usuarioPerfil);
        }


        [Authorize]
        public ActionResult editarFotoPerfil()
        {
            return PartialView("_editarFotoPerfil");
        }


        [Authorize]
        public ActionResult editarFotoPerfilAction()
        {
            return View();
        }



        [Authorize]
        public ActionResult EliminarCuenta(string usuarioNombre)
        {
            var toremove = context.User.FirstOrDefault(row => row.Nombre == usuarioNombre);
            context.User.Remove(toremove);
            context.SaveChanges();
            return HomeIndex();
        }
        

        

        public bool CanDelete(string usuarioNombre)
        {
            var usuario = context.User.FirstOrDefault(row => row.Nombre == usuarioNombre);
            if (usuario.Rol.CanDelete)
            {
                return true;
            }
            return false;
        }


        public ActionResult HomeIndex()
        {
            return RedirectToAction("../Home/Index");
        }
    }
}