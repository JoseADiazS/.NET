using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionFinanciera
{
    class ObjetoFinanciero
    {
        //Atributos de instancia

        //Nombre Cliente
        private string nombreCliente;
        //Numero Cuenta
        private long numeroCuenta;
        //Saldo
        private double saldo;
        //Esta activo
        private bool esActivo;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public long NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public bool EsActivo { get => esActivo; set => esActivo = value; }

        //Constructores
        public ObjetoFinanciero() {}

        public ObjetoFinanciero(string nombreCliente, long numeroCuenta, double saldo, bool esActivo)
        {
            this.NombreCliente = nombreCliente;
            this.NumeroCuenta = numeroCuenta;
            this.Saldo = saldo;
            this.EsActivo = esActivo;
        }
    }
}
