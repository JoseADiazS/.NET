using System;

/**
 * Aplicacion para la aplicacion de herencia en figuras geometricas y sus atributos
 * Author: Jose Armando Diaz Segura
 * Electiva .NET 2019-1
 *
 * */

namespace AppHerencias
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Figura controladorFigura = new Figura();
            Cuadrado controladorCuadrado = new Cuadrado();
            Rectangulo controladorRectangulo = new Rectangulo();
            Circulo controladorCirculo = new Circulo();

            Console.WriteLine("**********************************************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Digite el lado del cuadrado");
            controladorCuadrado.Lado = Double.Parse(Console.ReadLine());
            controladorCuadrado.obtenerArea();
            controladorCuadrado.obtenerPerimetro();
            Console.WriteLine("**********************************************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("El area del cuadrado es: " + controladorCuadrado.Area);
            Console.WriteLine("El perimetro del cuadrado es: " + controladorCuadrado.Perimetro);
            Console.WriteLine("La diagonal del cuadrado es: " + controladorCuadrado.obtenerDiagonal());
            Console.WriteLine("**********************************************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Digite el largo del rectangulo: ");
            controladorRectangulo.Largo = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el ancho del rectangulo: ");
            controladorRectangulo.Ancho = Double.Parse(Console.ReadLine());
            controladorRectangulo.obtenerArea();
            controladorRectangulo.obtenerPerimetro();
            Console.WriteLine("**********************************************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("El area del rectangulo es: " + controladorRectangulo.Area);
            Console.WriteLine("El perimetro del rectangulo es: " + controladorRectangulo.Perimetro);
            Console.WriteLine("La diagonal del rectangulo es: " + controladorRectangulo.obtenerDiagonal());
            Console.WriteLine("Es: " + controladorRectangulo.determinarSiEsCuadrado() + " que el rectangulo sea un cuadrado");
            Console.WriteLine("*********************************************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Digite el radio del circulo: ");
            controladorCirculo.Radio = Double.Parse(Console.ReadLine());
            controladorCirculo.obtenerArea();
            controladorCirculo.obtenerPerimetro();
            Console.WriteLine("*********************************************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("El area del circulo es: " + controladorCirculo.Area);
            Console.WriteLine("El perimetro del circulo es: " + controladorCirculo.Perimetro);
            Console.WriteLine("La circunferencia del circulo es: " + controladorCirculo.obtenerCircunferencia());
            Console.WriteLine("El diametro del circulo es: " + controladorCirculo.obtenerDiametro());
            Console.WriteLine("*********************************************");
            Console.WriteLine("*********************************************");
            Console.Read();
        }
    }
}