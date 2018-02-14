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
            foreach (var item in AccountController.onlineUsers)
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

        public ActionResult verPerfil(string id)
        {
            User usuario = context.User.FirstOrDefault(row => row.UserId == id);
            return View("Perfil", usuario);
        }

        public PartialViewResult orderPosts(int seleccionado = 0)
        {
            List<Post> listaPosts = new List<Post>();
            switch (seleccionado)
            {
                case 2:
                    listaPosts = (from db in context.Post
                                  orderby db.Titulo
                                  select db).Take(50).ToList();
                    break;

                case 1:
                    listaPosts = (from db in context.Post
                                  orderby db.UserId
                                  select db).Take(50).ToList();
                    break;

                case 0:
                default:
                    listaPosts = (from db in context.Post
                                  orderby db.LastEdit
                                  select db).Take(50).ToList();
                    break;
            }

            return PartialView("_ultimosPosts", listaPosts);
        }

        public ActionResult leerPost(Post modelo)
        {
            return View("leerPost", modelo);
        }

        public ActionResult Buscar(int seleccionado = 0)
        {
            return View("Buscar", seleccionado);
        }

        public ActionResult Publicar()
        {
            return View("Publicar");
        }

        [HttpPost]
        public ActionResult Publicar(FormCollection formData)
        {

            User myUser = new User();
            myUser = context.User.FirstOrDefault(row => row.UserId == User.Identity.Name);
            if (myUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            Post myPost = new Post();
            myPost.Titulo = formData["Titulo"];
            myPost.Texto = formData["Texto"];
            myPost.LastEdit = DateTime.Now;
            myPost.UserId = myUser.UserId;

            context.Post.Add(myPost);
            context.SaveChanges();

            return View("Index");
        }
    }
}