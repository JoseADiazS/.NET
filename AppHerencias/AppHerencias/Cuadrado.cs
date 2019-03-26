using System;

namespace AppHerencias
{
    internal class Cuadrado : Figura
    {
        private double lado;

        public double Lado { get => lado; set => lado = value; }

        public double obtenerArea()
        {
            Area = Lado * Lado;
            return Area;
        }

        public double obtenerPerimetro()
        {
            Perimetro = 4 * Lado;
            return Perimetro;
        }

        public double obtenerDiagonal()
        {
            return Math.Sqrt(2) * Lado;
        }
    }
}