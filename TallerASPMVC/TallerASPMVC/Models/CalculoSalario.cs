using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerASPMVC.Models
{
    public class CalculoSalario
    {
        public double calcularSueldoBruto(int numeroHoras, double valorHora) =>  numeroHoras* valorHora ;

        public double calcularSalud(double sueldoBruto) => (sueldoBruto * 14.5) / 100;
        public double calcularPension(double sueldoBruto) => (sueldoBruto * 12.6) / 100;
        public double calcularRiesgo(double sueldoBruto,int nivelRiesgo)
        {
            double valorRiesgo = 0.0;
            switch (nivelRiesgo)
            {
                case 1:
                    valorRiesgo = (sueldoBruto * 5) / 100;
                    break;
                case 2:
                    valorRiesgo = (sueldoBruto * 14) / 100;
                    break;
                case 3:
                    valorRiesgo = (sueldoBruto * 16) / 100;
                    break;
                case 4:
                    valorRiesgo = (sueldoBruto * 33) / 100;
                    break;
            }
            return valorRiesgo;
        }
        public double calcularTotalDescuentos(double salud, double pension, double riesgos) => salud + pension + riesgos;
        public double calcularSueldoNeto(double sueldoBruto, double totalDescuentos) => sueldoBruto - totalDescuentos;
    }
}