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
            ViewBag.Allow = false;
            if (Request.Cookies["userName"] == null)
            {
                Response.Cookies["userName"].Value = "Guest";
            }
            ViewBag.AllowDelete = canDelete();

            return View("Index");
        }
        

        public ActionResult Test(string value)
        {
            ViewBag.Test = value;
            return View("Test");
        }

        [HttpPost]
        public ActionResult TestAction(FormCollection formData)
        {
            Response.Cookies[formData["cookie"]].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("Test");
        }


        public ActionResult List()
        {
            List<User> users = (from u in context.User
                                orderby u.UserId ascending
                                select u).ToList();

            return View("List", users);
        }

        [HttpPost]
        public ActionResult ListDeleteAction(FormCollection formData)
        {
            return RedirectToAction("EliminarCuenta", "perfil", new { usuarioNombre = formData["userName"] });
        }

        public bool canDelete ()
        {
            string username = Request.Cookies["userName"].Value;
            if (!string.IsNullOrWhiteSpace(username))
            {
                User usuario = context.User.FirstOrDefault(row => row.Nombre == username);
                if (usuario.Rol.CanDelete)
                {
                    return true;
                }
            }
            return false;
        }
    }
}