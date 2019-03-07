using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolucionFinanciera
{
    class LogicaCalculadora
    {
        private ObjetoFinanciero datosCliente;

        public ObjetoFinanciero DatosCliente { get => datosCliente; set => datosCliente = value; }

        //Visibilidad retorno nombreMetodo(parametros)
        //{
        //};

        
        /**
         * return double
         * params:
         * interesCompuesto: double
         * valorVenta:double
         * */
        public double calcularValorSaldo(double interesCompuesto, double valorVenta)
        {
            double valorSaldo = 0.0;
            if(interesCompuesto != 0 && datosCliente.Saldo != 0)
            {
                Console.WriteLine("intereses compuestos: {0}",interesCompuesto);
                Console.WriteLine("Saldo del cliente: " + datosCliente.Saldo);

                valorSaldo = Math.Sqrt((interesCompuesto + 3 * valorVenta) / (4 * Math.Pow(interesCompuesto, 3))) / (3 *Math.Pow(interesCompuesto,8)-(2*datosCliente.Saldo));

                Console.WriteLine("Resultado del cálculo: {0}", valorSaldo);
            }
            else
            {
                valorSaldo = datosCliente.Saldo;
            }

            return valorSaldo;
        }

        /**
         * return double
         * */
        public double calcularBonoBeneficio()
        {
            double bono = 0.0;

            if(datosCliente.Saldo > 10000 && datosCliente.Saldo <= 100000)
            {
                bono = (datosCliente.Saldo * 0.20);
            }
            return bono;
        }
    }
}
