using System;

namespace AppHerencias
{
    internal class Circulo : Figura
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public double obtenerArea()
        {
            Area = Math.PI * Math.Pow(Radio, 2);
            return Area;
        }

        public double obtenerPerimetro()
        {
            Perimetro = 2 * Math.PI * Radio;
            return Perimetro;
        }

        public double obtenerCircunferencia()
        {
            return 2 * Math.PI * Radio;
        }

        public double obtenerDiametro()
        {
            return 2 * Radio;
        }
    }
}