using System;

namespace TestJuego
{
    internal class Program
    {
        public void imprimirCadena(double[] cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.WriteLine(cadena[i]);
            }
        }

        private static void Main(string[] args)
        {
            LogicaJuego logica = new LogicaJuego();
            Program controlador = new Program();

            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.WriteLine("Digite la palabra a codificar: ");
            logica.PalabraCodificar = Console.ReadLine();
            Console.WriteLine("******************************");
            Console.WriteLine("La palabra que quiere codificar es: " + logica.PalabraCodificar);
            Console.WriteLine("******************************");
            Console.WriteLine("Digite la letra pista: ");
            logica.LetraPista = Char.Parse(Console.ReadLine());
            Console.WriteLine("******************************");
            Console.WriteLine("La letra pista es: " + logica.LetraPista);
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            logica.ArregloCodificado = logica.codificar(logica.PalabraCodificar, logica.LetraPista);
            Console.WriteLine("El codigo de la palabra " + logica.PalabraCodificar + " es:");
            controlador.imprimirCadena(logica.ArregloCodificado);
            Console.Read();
        }
    }
}