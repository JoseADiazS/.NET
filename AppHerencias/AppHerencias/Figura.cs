namespace AppHerencias
{
    internal class Figura
    {
        private string nombre;
        private string color;
        private string tipo;
        private double area;
        private double perimetro;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }

        public double obtenerArea()
        {
            return Area;
        }

        public double obtenerPerimetro()
        {
            return Perimetro;
        }
    }
}