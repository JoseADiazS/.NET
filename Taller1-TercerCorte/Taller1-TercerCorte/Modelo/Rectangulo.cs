using System;

namespace AppHerencias
{
    internal class Rectangulo : Figura
    {
        /// <summary>El ancho del rectangulo</summary>
        private double ancho;

        /// <summary>El largo del rectangulo</summary>
        private double largo;

        /// <summary>Gets y sets del ancho</summary>
        /// <value>  El ancho.</value>
        public double Ancho { get => ancho; set => ancho = value; }

        /// <summary>Gets y sets del largo.</summary>
        /// <value>  El largo.</value>
        public double Largo { get => largo; set => largo = value; }

        /// <summary>  Metodo para obtener el area del rectangulo</summary>
        /// <returns>Valor del area del rectangulo</returns>
        public double obtenerArea()
        {
            Area = Largo * Ancho;
            return Area;
        }

        /// <summary>  Metodo para obtener el perimetro del rectangulo</summary>
        /// <returns>Valor del perimetro del rectangulo</returns>
        public double obtenerPerimetro()
        {
            Perimetro = 2 * (Largo + Ancho);
            return Perimetro;
        }

        /// <summary>Metodo para obtener la diagonal del rectangulo</summary>
        /// <returns>El valor de la diagonal del rectangulo</returns>
        public double obtenerDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largo, 2) + Math.Pow(Ancho, 2));
        }

        /// <summary>Metodo para determinar si el rectangulo es un cuadrado.</summary>
        /// <returns>True si el rectangulo es un cuadrado, false si no lo es.</returns>
        public bool determinarSiEsCuadrado()
        {
            return (Largo == Ancho);
        }
    }
}