using Quiz;
using System;

/**
 * Author Jose Armando Diaz Segura
 * Electiva .NET
 * 2019-1
 *
 * */

namespace QuizPunto1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program controlador = new Program();

            //Cambios visuales para la consola
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            //Llamado al modelado
            LogicaPunto1 Logica1 = new LogicaPunto1();

            //VariablesPunto1
            long numLong = 0;
            int numInt = 0;
            double numDouble = 0;
            int opcion = 0;

            //Ingreso de datos
            Console.WriteLine("Ingrese el numero long");
            numLong = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero int");
            numInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero double");
            numDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            //Transformación del numero largo en entero(si es posible) y real
            Console.WriteLine("El numero long ingresado fue: " + numLong);
            if (Logica1.ConvertirNumLongToInt(numLong) == -1)
            {
                Console.WriteLine("El numero es demasiado grande para ser un Entero");
            }
            else
            {
                Console.WriteLine("El numero entero del long es: " + Logica1.ConvertirNumLongToInt(numLong));
            }
            Console.WriteLine("El numero double del long es: " + Logica1.ConvertirNumLongToDouble(numLong));
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            //Conversión del numero entero en largo y real
            Console.WriteLine("El numero entero ingresado fue: " + numInt);
            Console.WriteLine("El numero long del entero es: " + Logica1.ConvertirNumIntToLong(numInt));
            Console.WriteLine("El numero double del entero es: " + Logica1.ConvertirNumIntToDouble(numInt));
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            //Conversión del numero real en largo y entero
            Console.WriteLine("El numero real ingresado fue: " + numDouble);
            Console.WriteLine("El numero entero del real es: " + Logica1.ConvertirNumDoubleToInt(numDouble));
            Console.WriteLine("El numero long del real es: " + Logica1.ConvertirNumDoubleToLong(numDouble));
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            //Fin de la aplicación
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();
        }
    }
}