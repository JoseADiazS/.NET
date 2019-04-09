using System;

namespace AppHerencias
{
    internal class Circulo : Figura
    {
        /// <summary>  El radio</summary>
        private double radio;

        /// <summary>Gets y sets del radio.</summary>
        /// <value>  El radio.</value>
        public double Radio { get => radio; set => radio = value; }

        /// <summary>Metodo para obtener el area.</summary>
        /// <returns>valor del area del circulo</returns>
        public double obtenerArea()
        {
            Area = Math.PI * Math.Pow(Radio, 2);
            return Area;
        }

        /// <summary>Metodo para obtener el perimetro del circulo.</summary>
        /// <returns>valor del perimetro del circulo</returns>
        public double obtenerPerimetro()
        {
            Perimetro = 2 * Math.PI * Radio;
            return Perimetro;
        }

        /// <summary>Metodo para obtener la circunferencia el circulo.</summary>
        /// <returns>Valor de la circunferencia del circulo</returns>
        public double obtenerCircunferencia()
        {
            return 2 * Math.PI * Radio;
        }

        /// <summary>Metodo para obtener el diametro del circulo.</summary>
        /// <returns>
        ///   <para>Valor del diametro del circulo</para>
        /// </returns>
        public double obtenerDiametro()
        {
            return 2 * Radio;
        }
    }
}