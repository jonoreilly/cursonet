using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gaia.Donosti.MVC4.Models;

namespace Gaia.Donosti.MVC4.Controllers
{
    public class Controlador1Controller : Controller
    {
        AdventureWorks2012Entities context = new AdventureWorks2012Entities();

        //// GET: Controlador1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var cliente = context.Customer.Find(id);

            if (cliente != null)
            {
                return View("Details", cliente);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Index2(int id)
        {
            List<Customer> listaClientes = new List<Customer>();

            for (int i = 0; i < 5; i++)
            {
                var cliente = context.Customer.Find(id + i);
                if (cliente != null)
                {
                    listaClientes.Add(cliente);
                }
            }
            return View("Index", listaClientes);
        }
    }
}