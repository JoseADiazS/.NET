using System;

namespace SolucionFinanciera
{
    internal class Program
    {
        //Referencia a la clase de la lógica
        private static LogicaCalculadora calculadora;

        public ObjetoFinanciero leerDatosCliente()
        {
            ObjetoFinanciero portafolio = new ObjetoFinanciero();

            portafolio.NombreCliente = leerCadena("Ingrese el nombre del cliente: ");
            portafolio.NumeroCuenta = long.Parse(leerCadena("Ingrese el numero de cuenta del cliente: "));
            portafolio.Saldo = leerValorReal("Ingrese el valor del saldo original del cuentahabiente: ");
            portafolio.EsActivo = true;

            return portafolio;
        }

        public double leerValorReal(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(System.Console.ReadLine());
        }

        public string leerCadena(string mensaje)
        {
            Console.WriteLine(mensaje);
            return System.Console.ReadLine();
        }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            double interesValorSaldo = 0.0;
            double interesCompuesto = 0.0;
            double valorVenta = 0.0;

            Program programaPrincipal = new Program();
            ObjetoFinanciero datosClientes = null;

            //Lectura de datos
            datosClientes = programaPrincipal.leerDatosCliente();

            calculadora = new LogicaCalculadora();
            calculadora.DatosCliente = datosClientes;

            interesCompuesto = programaPrincipal.leerValorReal("Digite el interes compuesto: ");
            valorVenta = programaPrincipal.leerValorReal("Digite el valor de venta: ");

            interesValorSaldo = calculadora.calcularValorSaldo(interesCompuesto, valorVenta);

            Console.WriteLine("***********");
            Console.WriteLine("Nombre cliente{0} - Numero cuenta{1}", datosClientes.NombreCliente, datosClientes.NumeroCuenta);

            Console.WriteLine("Valor del interes del saldo " + interesValorSaldo);

            Console.Write("pulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}