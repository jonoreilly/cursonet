﻿using System;
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

        public ActionResult loginPage()
        {
            return View("loginPage");
        }

        [HttpPost]
        public ActionResult loginAction(User userParam)
        {
            if (userParam.nombreUsuario == null || userParam.contraseña == null)
            {
                ViewBag.error = "incorrect";
                return View("loginPage");
            }

            if (context.User.SingleOrDefault(user => user.nombreUsuario == userParam.nombreUsuario) != null)
            {
                ViewBag.error = "again";
                return View("LoginPage");
            }

            usuario.nombreUsuario = userParam.nombreUsuario;
            usuario.contraseña = userParam.contraseña;
            usuario.rolID = 0;
            context.User.Add(usuario);
            User miusuario = context.User.SingleOrDefault(user => user.nombreUsuario == usuario.nombreUsuario);
            context.SaveChanges();
            if (miusuario != null)
            {
                usuario.usuarioID = miusuario.usuarioID;
            }

            return RedirectToAction("../App/Index");
        }

        public ActionResult logout ()
        {
            return View("logout");
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
        
        [HttpPost]
        public ActionResult registerAction(User userParam)
        {
            if (userParam.nombreUsuario == null || userParam.contraseña == null)
            {
                ViewBag.error = "incorrect";
                return View("Register");
            }

            if (context.User.SingleOrDefault(user => user.nombreUsuario == userParam.nombreUsuario) != null)
            {
                ViewBag.error = "again";
                return View("Register");
            }

            usuario.nombreUsuario = userParam.nombreUsuario;
            usuario.contraseña = userParam.contraseña;
            usuario.rolID = 0;
            context.User.Add(usuario);
            User miusuario = context.User.SingleOrDefault(user => user.nombreUsuario == usuario.nombreUsuario);
            context.SaveChanges();

            if (miusuario != null)
            {
                usuario.usuarioID = miusuario.usuarioID;
            }

            return RedirectToAction("../App/Index");
        }


        public ActionResult borrar()
        {
            return View("Borrar");
        }

        public ActionResult borrarAction()
        {
            context.User.Remove(usuario);
            context.SaveChanges();
            return View("logoutAction");
        }


        public ActionResult editar()
        {
            return View("Editar");
        }

        public ActionResult checkEditor()
        {
            ViewBag.var = "editar";
            return View("notAllowed");
        }

        public ActionResult editarAction(User userParam)
        {
            usuario.nombreUsuario = userParam.nombreUsuario;
            usuario.contraseña = userParam.contraseña;
            return RedirectToAction("../App/Index");
        }

        public ActionResult backToApp ()
        {
            return View("../App/Index");
        }
    }
}