using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvclogin.Models;

namespace mvclogin.Controllers
{
    public class PerfilController : Controller
    {

        AccountEntities context = new AccountEntities();

        User usuario = new User();

        // GET: Perfil
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult loginPage ()
        {
            return View("loginPage");
        }

        [HttpPost]
        public ActionResult loginAction (User userData)
        {
            if(context.User.Find(userData.nombreUsuario) == null)
            {
                usuario.nombreUsuario = userData.nombreUsuario;
                usuario.contraseña = userData.contraseña;
                usuario.rolID = 1;
                context.User.Add(usuario);
                usuario.usuarioID = context.User.Find(usuario.nombreUsuario).usuarioID;
            }
            return RedirectToAction("../App/Index");
        }

        public ActionResult logoutAction()
        {
            usuario = new User();
            return RedirectToAction("../App/Index");
        }

        public ActionResult register()
        {
            return View("Register");
        }

        public ActionResult registerAction ()
        {
            return RedirectToAction("../App/Index");
        }


        public ActionResult borrar()
        {
            return View("Borrar");
        }

        public ActionResult borrarAction (User usuario)
        {
            context.User.Remove(usuario);
            context.SaveChanges();
            return View("logoutAction");
        }
        

        public ActionResult editar ()
        {
            return View("Editar");
        }

        public ActionResult checkEditor ()
        {
                ViewBag.var = "editar";
                return View("notAllowed");
        }

        public ActionResult editarAction ()
        {
            return RedirectToAction("../App/Index");
        }
    }
}