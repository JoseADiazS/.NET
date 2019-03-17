using System;

namespace AppManejoTipos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Uso de la funcion Convert de tipo explicita
            ulong datoDestino = 0;
            char caracter = '8';
            datoDestino = Convert.ToUInt64(caracter);

            ulong dato1 = 78;
            char destino2 = '\0';
            destino2 = Convert.ToChar(dato1);

            ulong dato3 = 64;
            char destino3 = '\0';
            destino3 = (char)dato3;
            Console.WriteLine("Conversion a ulong: " + datoDestino);
            Console.WriteLine("Conversion a char: " + destino2);
            Console.WriteLine("Conversion a explicita al char: " + destino3);

            Console.ReadLine();
        }
    }
}