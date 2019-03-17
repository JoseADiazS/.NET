using System;

/**
 * Author Jose Armando Diaz Segura
 * Electiva .NET
 * 2019-1
 *
 * */

namespace AppPalabrasPalindroma
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program controlador = new Program();
            LogicaPunto2 Logica2 = new LogicaPunto2();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            //Variables
            string palabra = "";
            string palabra2 = "";
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            //Registro de las palabras a verificar
            Console.WriteLine("Digite la palabra 1: ");
            palabra = Console.ReadLine();
            Console.WriteLine("Digite la palabra 2: ");
            palabra2 = Console.ReadLine();
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            //Verificación de el tamaño de cada palabra
            Console.WriteLine("El tamaño de la palabra 1 es: " + Logica2.tamañoPalabra(palabra));
            Console.WriteLine("El tamaño de la palabra 2 es: " + Logica2.tamañoPalabra(palabra2));
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            //Verificacion para determinar si las palabras son palindromas
            if (Logica2.esPalindroma(palabra))
            {
                Console.WriteLine(palabra + " es palindroma");
            }
            else
            {
                Console.WriteLine(palabra + " no es palindroma");
            }
            if (Logica2.esPalindroma(palabra2))
            {
                Console.WriteLine(palabra2 + " es palindroma");
            }
            else
            {
                Console.WriteLine(palabra2 + " no es palindroma");
            }
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            //Verificacion para determinar si ambas palabras son palindromas
            if (Logica2.esPalindroma(palabra) && Logica2.esPalindroma(palabra2))
            {
                Console.WriteLine("Las dos palabras son palindromas");
            }
            else
            {
                Console.WriteLine("Las dos palabras no son palindromas");
            }
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("Digite una tecla para finalizar");
            Console.Read();
        }
    }
}