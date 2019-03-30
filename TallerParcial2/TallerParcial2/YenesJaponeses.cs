namespace TallerParcial2
{
    internal class YenesJaponeses : InterfaceConversionMonedas
    {
        /// <summary>El nombre de la moneda</summary>
        private string nombre;

        /// <summary>  El valor de la moneda</summary>
        private double valor;

        /// <summary>Gets or sets del nombre.</summary>
        /// <value>  El nombre de la moneda.</value>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>Gets or sets del valor.</summary>
        /// <value>  El valor de la moneda.</value>
        public double Valor { get => valor; set => valor = value; }

        /// <summary>  Metodo para calcular la conversion de la moneda a otra divisa</summary>
        /// <param name="valorAConvertir">The valor a convertir.</param>
        /// <param name="tasa">The tasa.</param>
        /// <param name="direccionDeConversion">The direccion de convers
        /// /// <returns>El valor de la conversión de la moneda</returns>
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

        /// <summary>  Metodo para calcular el valor de la moneda en bitcoins</summary>
        /// <param name="valorAConvertir">The valor a convertir.</param>
        /// <returns>El valor de bitcoins de la moneda</returns>
        public double calcularConversionMonedaBitcoins(double valorAConvertir)
        {
            double bandera = valorAConvertir * 0.00090;
            return bandera * 0.00025;
        }

        /// <summary>  Metodo para obtener el nombre de la moneda</summary>
        /// <returns>El nombre de la moneda</returns>
        public string obtenerNombreMoneda()
        {
            return Nombre;
        }
    }
}