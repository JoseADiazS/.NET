using System;

namespace AppInterfaces
{
    public class Program
    {
        public void imprimirMenu()
        {
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("MENÚ DE OPCIONES DE SOBRECARGA");
            System.Console.WriteLine("1.  Digitar palabra a traducir");
            System.Console.WriteLine("2.  Traducir a Ingles");
            System.Console.WriteLine("3.  Traducir a Portugues");
            System.Console.WriteLine("4.  Traducir a Suajini");
            System.Console.WriteLine("5.  Salir");
        }

        private static void Main(string[] args)
        {
            Program controlador = new Program();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Idiomas idiomas;
            Ingles ingles = new Ingles();
            Portugues portugues = new Portugues();
            Suajini suajini = new Suajini();
            int seleccion = 0;
            string palabraATraducir = "";

            do
            {
                controlador.imprimirMenu();
                Console.WriteLine("Digite una opcion: ");
                seleccion = Int32.Parse(Console.ReadLine());
                if (seleccion != 5)
                {
                    switch (seleccion)
                    {
                        case 1:
                            Console.WriteLine("Digite la palabra a traducir: ");
                            palabraATraducir = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine(ingles.traducir(palabraATraducir));
                            break;

                        case 3:
                            Console.WriteLine(portugues.traducir(palabraATraducir));
                            break;

                        case 4:
                            Console.WriteLine(suajini.traducir(palabraATraducir));
                            break;
                    }
                }
            } while (seleccion != 5);
        }
    }
}