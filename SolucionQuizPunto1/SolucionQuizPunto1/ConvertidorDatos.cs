using System;

namespace SolucionQuizPunto1
{
    internal class ConvertidorDatos
    {
        private DatosConvertidos objetoInformacion;

        /**
         * Definir la logica para convertir el dato de entrada y generar
         * sus equivalents en los otros dos tipos
         * */

        public DatosConvertidos convertirTipoNumericoADestinos(int numero1, double numero2, long numero3, char tipoNumero)
        {
            objetoInformacion = new DatosConvertidos();
            int destino1 = 0;
            double destino2 = 0;
            long destino3 = 0L;
            switch (tipoNumero)
            {
                case 'i':
                    //Conversion correspondiente de entero a real y largo
                    destino2 = (double)numero1;
                    destino3 = (long)numero1;
                    objetoInformacion.Dato1 = destino2;
                    objetoInformacion.Dato2 = destino3;
                    break;

                case 'r':
                    //Conversion del double a entero y al largo
                    destino1 = (int)numero2;
                    destino3 = (long)numero2;
                    objetoInformacion.Dato1 = destino1;
                    objetoInformacion.Dato2 = destino3;
                    break;

                case 'l':
                    destino1 = (int)numero3;
                    destino2 = (double)numero3;
                    objetoInformacion.Dato1 = destino1;
                    objetoInformacion.Dato2 = destino2;

                    break;

                default:
                    Console.WriteLine("No es posible convertir el tipo de dato");
                    objetoInformacion.Dato1 = "No se pudo convertir el dato";
                    objetoInformacion.Dato2 = "No se pudo convertir el dato";
                    break;
            }
            return objetoInformacion;
        }
    }
}