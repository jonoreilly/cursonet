using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvclogin.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult login ()
        {
            return RedirectToAction("../Perfil/loginPage");
        }

        public ActionResult register()
        {
            return RedirectToAction("../Perfil/register");
        }

        public ActionResult borrar()
        {
            return RedirectToAction("../Perfil/borrar");
        }

        public ActionResult editar()
        {
            return RedirectToAction("../Perfil/editar");
        }
    }
}