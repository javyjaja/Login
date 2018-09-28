using login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace login.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var o = db.Users.ToList();

            var lista = new List<userViewModel>();

            foreach (var item in o)
            {
                var usuario = new userViewModel();
                usuario.Id = item.IdAuto;
                usuario.Usuario = item.UserName;
                usuario.Correo = item.Email;
                usuario.Sexo = item.Sexo;
                usuario.Estatus = item.Estatus == true ? "Activo" : "Inactivo";
                lista.Add(usuario);
            }
    
            return View(lista);
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