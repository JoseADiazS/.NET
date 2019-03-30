namespace TallerParcial2
{
    internal interface InterfaceConversionMonedas
    {
        double calcularConversionMoneda(double valorAConvertir, double tasa, string direccionDeConversion);

        double calcularConversionMonedaBitcoins(double valorAConvertir);

        string obtenerNombreMoneda();
    }
}