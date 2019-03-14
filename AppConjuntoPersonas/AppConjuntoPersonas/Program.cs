using System;
using System.Collections.Generic;

/**
 * Taller #2 del segundo corte de C#
 * Aplicación Ordenamiento, Extraccion de datos de un grupo de personas.
 * José Armando Diaz Segura
 * Cristian Camilo Ricaurte
 *
 * */

namespace AppConjuntoPersonas
{
    internal class Program
    {
        public void imprimirMenu()
        {
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("MENÚ DE OPCIONES DE SOBRECARGA");
            System.Console.WriteLine("1.  Agregar una persona a la lista");
            System.Console.WriteLine("2.  Cual es la persona mas joven");
            System.Console.WriteLine("3.  Cual es la persona mas anciana");
            System.Console.WriteLine("4.  Conocer el promedio de edad de las personas");
            System.Console.WriteLine("5.  Ordenar las edades de las personas de menor a mayor");
            System.Console.WriteLine("6.  Salir");
        }

        private static void Main(string[] args)
        {
            List<Persona> ArregloPersonas = new List<Persona>();
            Program controlador = new Program();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            int select = 0;
            Persona persona = new Persona("", 0);
            Modelado modelado = new Modelado();
            do
            {
                System.Console.WriteLine("Menu de Opciones");
                controlador.imprimirMenu();
                System.Console.Write("Digite una opcion: ");
                select = Int32.Parse(Console.ReadLine());

                if (select != 6)
                {
                    switch (select)
                    {
                        case 1:
                            System.Console.WriteLine("Dijite el nombre");
                            string nombre = System.Console.ReadLine();
                            System.Console.WriteLine("Dijite la edad");
                            int edad = System.Int32.Parse(System.Console.ReadLine());
                            var persona2 = new Persona(nombre, edad);
                            ArregloPersonas.Add(persona2);
                            System.Console.WriteLine(ArregloPersonas.Count);
                            break;

                        case 2:
                            var MasJoven = modelado.GetPersonaMasJoven(ArregloPersonas);
                            System.Console.WriteLine("La persona mas joven es " + MasJoven.Item1);
                            System.Console.WriteLine("Con " + MasJoven.Item2 + " años");
                            break;

                        case 3:
                            var MasVieja = modelado.GetPersonaMasVieja(ArregloPersonas);
                            System.Console.WriteLine("La persona mas vieja es " + MasVieja.Item1);
                            System.Console.WriteLine("Con " + MasVieja.Item2 + " años");
                            break;

                        case 4:
                            var Promedio = modelado.GetPromedioPersonas(ArregloPersonas);
                            System.Console.WriteLine("El promedio de edad del conjunto de personas es: " + Promedio);
                            break;

                        case 5:
                            Console.WriteLine("El orden de menor a mayor es: ");
                            var Orden = modelado.OrdenarArregloEdades(ArregloPersonas);
                            foreach (Persona persona3 in Orden)
                                Console.WriteLine(persona3.Nombre + " " + persona3.Edad);
                            break;
                    }
                }
            }
            while (select != 6);
            Console.WriteLine("El programa ha terminado");
        }
    }
}