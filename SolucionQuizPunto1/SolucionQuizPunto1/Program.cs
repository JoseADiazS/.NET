using System;

namespace SolucionQuizPunto1
{
    internal class Program
    {
        private static ConvertidorDatos controladorConversion;

        public object leerEntradaGenerica(string mensajeEntrada, char tipo)
        {
            object valor = null;
            int numero1 = 0;
            double numero2 = 0;
            long numero3 = 0;
            Console.Write(mensajeEntrada);
            switch (tipo)
            {
                case 'i':
                    numero1 = Int32.Parse(Console.ReadLine());
                    valor = numero1;
                    break;

                case 'r':
                    numero2 = double.Parse(Console.ReadLine());
                    valor = numero2;
                    break;

                case 'l':
                    numero3 = long.Parse(Console.ReadLine());
                    valor = numero3;
                    break;
            }

            return valor;
        }

        //Metodo para imprimir los resultados
        public void mostrarResultados(object original, object dato1, object dato2, char tipo)
        {
            string mensajeRespuesta = "";

            if (tipo == 'i')
            {
                mensajeRespuesta = "El dato " + original + " es en double " + dato1 + " y en largo " + dato2;
            }
            else if (tipo == 'r')
            {
                mensajeRespuesta = "El dato " + original + " es en entero " + dato1 + " y en largo " + dato2;
            }
            else if (tipo == 'l')
            {
                mensajeRespuesta = "El dato " + original + " es en entero " + dato1 + " y en real " + dato2;
            }

            Console.WriteLine(mensajeRespuesta);
        }

        private static void Main(string[] args)
        {
            controladorConversion = new ConvertidorDatos();

            Program controladorMain = new Program();

            DatosConvertidos datosUsuarios = new DatosConvertidos();

            int n1 = 0;
            double n2 = 0;
            long n3 = 0;

            //Invoco el servicio de captura de la capa de presentacion para luego
            //enviar esos datos al servicio de negocio
            n1 = (int)controladorMain.leerEntradaGenerica("Ingrese el entero: ", 'i');
            n2 = (double)controladorMain.leerEntradaGenerica("Ingrese el real: ", 'r');
            n3 = (long)controladorMain.leerEntradaGenerica("Ingrese el largo: ", 'l');

            datosUsuarios = controladorConversion.convertirTipoNumericoADestinos(n1, n2, n3, 'i');
            controladorMain.mostrarResultados(n1, datosUsuarios.Dato1, datosUsuarios.Dato2, 'i');

            Console.WriteLine("Pulse una tecla para finalizar");
            Console.Read();
        }
    }
}