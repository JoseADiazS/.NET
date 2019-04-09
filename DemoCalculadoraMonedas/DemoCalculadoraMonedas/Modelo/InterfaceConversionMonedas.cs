using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorMonedasWPF.modelo
{
    //***************************************************************************
    //***************************************************************************
    //***************************************************************************
    public interface InterfaceConversionMonedas
    {
        double calcularConversionMoneda(double valorOrigen, double tasaCambio, char tipo);
        string obtenerNombreMoneda(string mon);
        double calcularConversionMonedaBitcoins(double valor, string tipoMoneda);
    }
    //***************************************************************************
    //***************************************************************************
    //***************************************************************************
}
