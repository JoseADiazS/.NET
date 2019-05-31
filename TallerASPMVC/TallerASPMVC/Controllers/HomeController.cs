using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerASPMVC.Models;

namespace TallerASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult CalculoSalarial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculoSalarial(int numHorasEmpleado, double valHoraEmpleado, int nivelRiesgo,string nombreEmpleado,string apellidoEmpleado)
        {
            CalculoSalario calculoSalario = new CalculoSalario();
            double SueldoBruto = calculoSalario.calcularSueldoBruto(numHorasEmpleado, valHoraEmpleado);
            double Salud = calculoSalario.calcularSalud(SueldoBruto);
            double Pension = calculoSalario.calcularPension(SueldoBruto);
            double Riesgos = calculoSalario.calcularRiesgo(SueldoBruto, nivelRiesgo);
            double TotalDeducciones = calculoSalario.calcularTotalDescuentos(Salud, Pension, Riesgos);
            double SueldoNeto = calculoSalario.calcularSueldoNeto(SueldoBruto, TotalDeducciones);
            ViewBag.Nombre = nombreEmpleado;
            ViewBag.Apellido = apellidoEmpleado;
            ViewBag.NumeroHoras = numHorasEmpleado;
            ViewBag.ValorHora = valHoraEmpleado;
            ViewBag.SueldoBruto = SueldoBruto;
            ViewBag.Salud = Salud;
            ViewBag.Pension = Pension;
            ViewBag.Riesgos = Riesgos;
            ViewBag.TotalDescuentos = TotalDeducciones;
            ViewBag.SueldoNeto = SueldoNeto;

            return View();
        }
        public ActionResult CalculoNotas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculoNotas(string nombreEstudiante,string apellidoEstudiante,double valNota1,double valNota2,double valNota3)
        {
            CalculoNotas calculoNotas = new CalculoNotas();
            double Nota1 = calculoNotas.calculoNota1(valNota1);
            double Nota2 = calculoNotas.calculoNota2(valNota2);
            double Nota3 = calculoNotas.calculoNota3(valNota3);
            double Definitiva = calculoNotas.calculoDefinitiva(Nota1,Nota2,Nota3);
            ViewBag.Nombre = nombreEstudiante;
            ViewBag.Apellido = apellidoEstudiante;
            ViewBag.Nota1 = valNota1;
            ViewBag.Nota2 = valNota2;
            ViewBag.Nota3 = valNota3;
            ViewBag.Nota3 = valNota3;
            ViewBag.NotaI = Nota1;
            ViewBag.NotaII = Nota2;
            ViewBag.NotaIII = Nota3;
            ViewBag.NotaDefinitiva = Definitiva;

            return View();
        }
    }
}