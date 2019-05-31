using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAppMVC.Models
{
    public class LogicaCadenas
    {
        //*********************************************
        //*********************************************
        //*********************************************
        private string cadenaCaracteres;

        //*********************************************
        //*********************************************
        //*********************************************
        public string CadenaCaracteres { get => cadenaCaracteres; set => cadenaCaracteres = value; }

        //*********************************************
        //*********************************************
        //*********************************************
        //Servicio expuesto por el objeto de LogicaCadenas
        public string invertirCadenaCaracteres(string cadenaOriginal)
        {
            //Variables locales
            string cadenaInvertida = "";
            int i = 0;
            char caracter = '\0';

            //Recorremos la cadena de atrás hacia adelante
            for (i = cadenaOriginal.Length - 1; i >= 0; i--)
            {
                //Sacamos el caracter actual de la cadena
                caracter = cadenaOriginal[i];
                //Lo agregamos a la cadena que va a tener la palabra
                //invertida
                cadenaInvertida += caracter;
            }

            //Retornamos la cadena invertida
            return (cadenaInvertida);
        }

        //*********************************************
        //*********************************************
        //*********************************************
        public string convertirCadenaMayusculas(string cadenaOriginal)
        {
            string cadenaMayusculas = "";
            System.Console.WriteLine("Cadena ingresada: " + cadenaOriginal);
            cadenaMayusculas = cadenaOriginal.ToUpper();
            System.Console.WriteLine("Cadena en mayusculas: " + cadenaMayusculas);
            return (cadenaMayusculas);
        }
        //*********************************************
        //*********************************************
        //*********************************************
        //*********************************************
    }
}
