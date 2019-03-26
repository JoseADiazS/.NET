using System;

namespace AppHerencias
{
    internal class Rectangulo : Figura
    {
        private double ancho;
        private double largo;

        public double Ancho { get => ancho; set => ancho = value; }
        public double Largo { get => largo; set => largo = value; }

        public double obtenerArea()
        {
            Area = Largo * Ancho;
            return Area;
        }

        public double obtenerPerimetro()
        {
            Perimetro = 2 * (Largo + Ancho);
            return Perimetro;
        }

        public double obtenerDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largo, 2) + Math.Pow(Ancho, 2));
        }

        public bool determinarSiEsCuadrado()
        {
            return (Largo == Ancho);
        }
    }
}