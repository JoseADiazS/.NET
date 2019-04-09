namespace AppHerencias
{
    internal class Figura
    {
        /// <summary>  El nombre de la figura</summary>
        private string nombre;

        /// <summary>  El color de la figura</summary>
        private string color;

        /// <summary>  El tipo de la figura</summary>
        private string tipo;

        /// <summary>  Valor del area de la figura</summary>
        private double area;

        /// <summary>  Valor del perimetro de la figura</summary>
        private double perimetro;

        /// <summary>Getsy sets del nombre de la figura.</summary>
        /// <value>  El nombre.</value>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>Getsy sets del color de la figura.</summary>
        /// <value>  El color.</value>
        public string Color { get => color; set => color = value; }

        /// <summary>Getsy sets del tipo de la figura.</summary>
        /// <value>  El tipo.</value>
        public string Tipo { get => tipo; set => tipo = value; }

        /// <summary>Getsy sets del Area de la figura.</summary>
        /// <value>  El area.</value>
        public double Area { get => area; set => area = value; }

        /// <summary>Getsy sets del perimetro de la figura.</summary>
        /// <value>  El perimetro.</value>
        public double Perimetro { get => perimetro; set => perimetro = value; }

        /// <summary>  Metodo para obtener el area de la figura</summary>
        /// <returns>Valor del area de la figura</returns>
        public double obtenerArea()
        {
            return Area;
        }

        /// <summary>  Metodo para obtener el perimetro de la figura</summary>
        /// <returns>Valor del perimetro de la figura</returns>
        public double obtenerPerimetro()
        {
            return Perimetro;
        }
    }
}