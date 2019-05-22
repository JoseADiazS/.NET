using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MiPrimeraAppMVC.Models
{

    public class DatosContacto
    {
        [Display(Name = "registroEmpleado")]
        private string code;
        private string nombre;
        private int edad;
        private double salario;

        public string Code { get => code; set => code = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}