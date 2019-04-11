using System;

namespace TallerWPF
{
    internal class Cuadrado : Figura
    {
        /// <summary>Valor del lado del cuadrado</summary>
        private double lado;

        /// <summary>Gets y sets del lado del cuadrado</summary>
        /// <value>  Valor del lado del cuadrado</value>
        public double Lado { get => lado; set => lado = value; }

        /// <summary>  Metodo para obtener el valor del Area del cuadrado</summary>
        /// <returns>Valor del area del cuadrado</returns>
        public double obtenerArea()
        {
            Area = Lado * Lado;
            return Area;
        }

        /// <summary>  Metodo para obtener el valor del perimetro del cuadrado</summary>
        /// <returns>Valor del perimetro del cuadrado</returns>
        public double obtenerPerimetro()
        {
            Perimetro = 4 * Lado;
            return Perimetro;
        }

        /// <summary>  Metodo para obtener el valor de la diagonal del cuadrado</summary>
        /// <returns>Valor de la diagonal del cuadrado</returns>
        public double obtenerDiagonal()
        {
            return Math.Sqrt(2) * Lado;
        }
    }
}