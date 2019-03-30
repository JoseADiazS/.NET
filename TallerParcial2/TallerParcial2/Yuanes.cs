namespace TallerParcial2
{
    internal class Yuanes : InterfaceConversionMonedas
    {
        private string nombre;
        private double valor;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Valor { get => valor; set => valor = value; }

        public double calcularConversionMoneda(double valorAConvertir, double tasa, string direccionDeConversion)
        {
            direccionDeConversion.ToUpper();
            double bandera = 0.0;
            if (direccionDeConversion == "OD")
            {
                bandera = valorAConvertir * tasa;
            }
            else if (direccionDeConversion == "DO")
            {
                bandera = valorAConvertir / tasa;
            }
            return bandera;
        }

        public double calcularConversionMonedaBitcoins(double valorAConvertir)
        {
            double bandera = valorAConvertir * 0.15;
            return bandera * 0.00025;
        }

        public string obtenerNombreMoneda()
        {
            return Nombre;
        }
    }
}