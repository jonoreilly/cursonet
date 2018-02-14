using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patata.Models;

namespace patata.Controllers
{
    public class HomeController : Controller
    {
        AnunciolandiaEntities context = new AnunciolandiaEntities();

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (context.User.FirstOrDefault(row => row.UserId == User.Identity.Name) == null)
                {
                    User myuser = new User();
                    myuser.UserId = User.Identity.Name;
                    myuser.Nombre = User.Identity.Name;
                    myuser.RolId = 1;
                    context.User.Add(myuser);
                    context.SaveChanges();
                }
            }


            return View(listarUsuarios());
            

        }

        public List<User> listarUsuarios()
        {
            List<User> listaUsuarios = new List<User>();
            foreach(var item in AccountController.onlineUsers)
            {
                listaUsuarios.Add(context.User.FirstOrDefault(row => row.UserId == item));
            }
            return listaUsuarios;
        }


        public string getUserName()
        {
            return context.User.FirstOrDefault(row => row.UserId == User.Identity.Name).Nombre;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult changeUsername(FormCollection formData)
        {
            User myuser = context.User.FirstOrDefault(row => row.UserId == User.Identity.Name);
            myuser.Nombre = formData["userName"];
            context.SaveChanges();
            return RedirectToAction("Index", "Manage");
        }

        public ActionResult verPerfil (string id)
        {
            User usuario = context.User.FirstOrDefault(row => row.UserId == id);
            return View("Perfil", usuario);
        }

        public PartialViewResult ultimosPosts ()
        {
            List<Post> listaPosts = (from db in context.Post
                                     orderby db.LastEdit
                                     select db).Take(10).ToList();
            

            return PartialView("_ultimosPosts", listaPosts);
        }

        public ActionResult leerPost (Post modelo)
        {
            return View("leerPost", modelo);
        }

    }
}