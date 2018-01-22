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

        AccountEntitiesReal context = new AccountEntitiesReal();

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
        public ActionResult loginAction (User userParam)
        {
            if(userParam.nombreUsuario == null || userParam.contraseña == null)
            {
                return View("loginPage");
            }

            if(context.User.Find(userParam.nombreUsuario) == null)
            {
                usuario.nombreUsuario = userParam.nombreUsuario;
                usuario.contraseña = userParam.contraseña;
                usuario.rolID = 1;
                context.User.Add(usuario);
                User miusuario = context.User.Find(usuario.nombreUsuario);
                if (miusuario != null)
                {
                    usuario.usuarioID = miusuario.usuarioID;
                }
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

        public ActionResult borrarAction ()
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

        public ActionResult editarAction (User userParam)
        {
            usuario.nombreUsuario = userParam.nombreUsuario;
            usuario.contraseña = userParam.contraseña;
            return RedirectToAction("../App/Index");
        }
    }
}