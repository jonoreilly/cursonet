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

        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Allow = false;
            if (Request.Cookies["userName"] == null)
            {
                Response.Cookies["userName"].Value = "Guest";
            }

            return View("Index");
        }
        

       
        public ActionResult getNameImage()
        {
            string myname = User.Identity.Name;
            User myuser = context.User.FirstOrDefault(row => row.Nombre == myname);
            return PartialView("_getNameImage", myuser);
        }


        public FileContentResult getImage(int id)
        {
            Foto myFoto = context.Foto.FirstOrDefault(row => row.FotoId == id);
            if (myFoto != null)
            {
                return File(myFoto.FotoArchivo, myFoto.FotoTipo);
            }
            else
            {
                return null;
            }
        }

    }
}