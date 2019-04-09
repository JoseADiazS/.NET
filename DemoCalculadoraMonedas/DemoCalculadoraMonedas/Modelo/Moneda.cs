using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorMonedasWPF.modelo
{
    public class Moneda:  InterfaceConversionMonedas
    {
        //*************************************************************
        //*************************************************************
        //*************************************************************
        //*************************************************************
        private double valor;
        private string nombre;
        //*************************************************************
        //*************************************************************
        protected double Valor { get => valor; set => valor = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        //*************************************************************
        //*************************************************************
        //*************************************************************
        //*************************************************************
        public Moneda()
        {
        }
        //*************************************************************
        //*************************************************************
        //*************************************************************
        public Moneda(double valor, string nombre, string tipoMoneda)
        {
            this.Valor = valor;
            this.Nombre = nombre;
        }
        //*************************************************************
        //*************************************************************
        //*************************************************************
        public double calcularConversionMoneda(double valorOrigen, double tasaCambio, char tipo)
        {
            double monedaConvertida = 0.0;

            if (tipo.Equals('a'))
            {
                Console.WriteLine("Convirtiendo por producto");
                monedaConvertida = valorOrigen * tasaCambio;
            }
            else
            {
                Console.WriteLine("Convirtiendo por cociente");
                monedaConvertida = valorOrigen / tasaCambio;
            }

            Console.WriteLine("Valor convertido: " + monedaConvertida);

            return (monedaConvertida);
        }
        //*************************************************************
        //*************************************************************
        //*************************************************************
        public string obtenerNombreMoneda(string mon)
        {
            string nombreMoneda = "";

            Console.WriteLine("Mon para el switch: " + mon);

            switch (mon)
            {
                case "Dólares":
                    nombreMoneda = "Dólares";
                    break;
                case "Euros":
                    nombreMoneda = "Euros";
                    break;
                case "Yuanes":
                    nombreMoneda = "Yuanes";
                    break;
                case "Yenes":
                    nombreMoneda = "Yenes";
                    break;
                case "Pesos colombianos":
                    nombreMoneda = "Pesos colombianos";
                    break;
            }

            Console.WriteLine("Moneda: " + nombreMoneda);

            return (nombreMoneda);
        }
        //*************************************************************
        //*************************************************************
        //*************************************************************
        public double calcularConversionMonedaBitcoins(double valor, string tipoMoneda)
        {
            double valorBitcoins = 0.0;
            double valorDolares = 0.0;

            if (tipoMoneda.Equals("Dólares"))
            {
                valorBitcoins = valor * 0.00025;
            }
            else
            {
                //Se debe convertir a dolares para pasarlo a bitcoins
                switch (tipoMoneda)
                {
                    case "Euros":
                        valorDolares = valor * 1.12;
                        break;
                    case "Yuanes":
                        valorDolares = valor * 0.15;
                        break;
                    case "Yenes":
                        valorDolares = valor * 0.0090;
                        break;
                    case "Pesos colombianos":
                        valorDolares = valor * 0.00031;
                        break;
                }

                valorBitcoins = valorDolares * 0.00025;
            }

            return (valorBitcoins);
        }
        //*************************************************************
        //*************************************************************
        //*************************************************************
        //*************************************************************
        //*************************************************************
        //*************************************************************
    }//Fin de la clase

}//Fin del namespace
