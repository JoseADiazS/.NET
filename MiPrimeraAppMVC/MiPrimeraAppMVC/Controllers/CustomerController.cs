using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimeraAppMVC.Models;


namespace MiPrimeraAppMVC.Controllers
{
    public class CustomerController : Controller
    {
        //************************************************************
        //************************************************************
        //************************************************************
        // GET: Customer
        /*
        public ActionResult Index()
        {
            DatosContacto objCustomer = new DatosContacto();
            objCustomer.Code = "3434432";
            objCustomer.Nombre = "Jaime Gutiérrez";
            objCustomer.Edad = 22;
            objCustomer.Salario = 1500000.56;

            return View("DisplayCustomer", objCustomer);
        }
        */
        //************************************************************
        //************************************************************
        //************************************************************
        //************************************************************
        //************************************************************
        //************************************************************
        //Controlador para enviar la respuesta del procesamiento del Request
        //A la vista de presentación
        public ViewResult DisplayCustomer()
        {
            DatosContacto registro = new DatosContacto();
            string codigo = "";
            string nombre = "";
            int edad = 0;
            double salario = 0.0;

            try
            {
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("Procesando el request: " + Request.Form.ToString());
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("************************************");
                //*****************************************************
                //*****************************************************
                codigo = Request.Form["txt_Code"].ToString();
                nombre = Request.Form["txt_Nombre"].ToString();
                edad = Convert.ToInt32(Request.Form["txt_Edad"].ToString());
                salario = Double.Parse(Request.Form["txt_Salario"].ToString());
                //*****************************************************
                //*****************************************************
                System.Diagnostics.Debug.WriteLine("codigo:  " + codigo);
                System.Diagnostics.Debug.WriteLine("nombre: " + nombre);
                System.Diagnostics.Debug.WriteLine("edad:" + edad);
                System.Diagnostics.Debug.WriteLine("salario:" + salario);
                //*****************************************************
                //*****************************************************
                //Encapsulamos
                registro.Code = codigo;
                registro.Nombre = nombre;
                registro.Edad = edad;
                registro.Salario = salario;
                //*****************************************************
                //*****************************************************
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("************************************");
            }

            catch (Exception errorProcesamientoControlador)
            {
                System.Diagnostics.Debug.WriteLine("Error en el controlador: " + errorProcesamientoControlador.Message);
                System.Diagnostics.Debug.WriteLine("Error detallado: " + errorProcesamientoControlador.ToString());
            }

            return View("DisplayCustomer",registro);
        }
        //************************************************************
        //************************************************************
        //************************************************************
        //Controlador para manipular el cargue de la vista del formulario de captura
        //de datos
        public ActionResult FillCustomer()
        {
            return View();
        }

        public ActionResult FormaCaptura()
        {
            return View();
        }
        //************************************************************
        //************************************************************
        //************************************************************
    }//Fin de la clase del controlador

}