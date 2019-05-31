using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerASPMVC.Models
{
    public class CalculoNotas
    {
        public double calculoNota1(double nota1) => nota1 * 0.3;
        public double calculoNota2(double nota2) => nota2 * 0.3;
        public double calculoNota3(double nota3) => nota3 * 0.4;
        public double calculoDefinitiva(double nota1, double nota2,double nota3) => nota1 + nota2 + nota3;
    }
}