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
            if(User.Identity.IsAuthenticated)
            {
                if(context.User.FirstOrDefault(row => row.UserId == User.Identity.Name) == null)
                {
                    User myuser = new User();
                    myuser.UserId = User.Identity.Name;
                    myuser.Nombre = User.Identity.Name;
                    myuser.RolId = 1;
                    context.User.Add(myuser);
                    context.SaveChanges();
                }
            }
            
            return View();
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}