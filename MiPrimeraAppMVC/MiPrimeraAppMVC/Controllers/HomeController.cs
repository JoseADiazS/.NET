using MiPrimeraAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private static LogicaCadenas fachadaCadenas;
        private static DatosContacto registroUsuario;

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mi primera aplicacion MVC"+ DateTime.Now.Year;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MiFormulario()
        {
            try
            {
                fachadaCadenas = new LogicaCadenas();
                ViewBag.valor1 = fachadaCadenas.invertirCadenaCaracteres("Jose Diaz");
                ViewBag.valor2 = fachadaCadenas.convertirCadenaMayusculas("mir primera app MVC con ViewBag");

            }
            catch(Exception error)
            {
                System.Diagnostics.Debug.WriteLine("Error " + error.Message);
            }

            return View();
        }

        //Controlador de la forma de datos
        public ActionResult FormaDatos()
        {
            registroUsuario = new DatosContacto();
            registroUsuario.Code = "973333";
            registroUsuario.Edad = 30;
            registroUsuario.Nombre = "Jaimito";
            registroUsuario.Salario = 1000000.34;

            return View(registroUsuario);

        }
    }
}