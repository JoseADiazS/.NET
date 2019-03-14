using System;

namespace AppCalculoSalario
{
    public class CalculoDeducciones
    {
        private double sueldo;
        private double salud;
        private double pension;
        private double riesgosPro;
        private double totalDeducciones;

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public double Salud { get => salud; set => salud = value; }
        public double Pension { get => pension; set => pension = value; }
        public double RiesgosPro { get => riesgosPro; set => riesgosPro = value; }
        public double TotalDeducciones { get => totalDeducciones; set => totalDeducciones = value; }

        public CalculoDeducciones(double sueldo, double salud, double pension,
            double riesgosPro, double totalDeducciones)
        {
            this.Sueldo = sueldo;
            this.Salud = salud;
            this.Pension = pension;
            this.RiesgosPro = riesgosPro;
            this.TotalDeducciones = totalDeducciones;
        }

        public double CalculoSalud()
        {
            Salud = ((Sueldo * 15) / 100);
            TotalDeducciones += Salud;
            return Salud;
        }

        public double CalculoRiesgos(int Seleccion)
        {
            if (Seleccion == 1)
            {
                RiesgosPro = ((Sueldo * 2) / 100);
            }
            else if (Seleccion == 2)
            {
                RiesgosPro = ((Sueldo * 7) / 100);
            }
            else if (Seleccion == 3)
            {
                RiesgosPro = ((Sueldo * 10) / 100);
            }
            TotalDeducciones += RiesgosPro;
            return RiesgosPro;
        }

        public double CalculoPension(double pension)
        {
            Pension = pension;
            TotalDeducciones += Pension;
            return Pension;
        }

        public double leerValorReal(string mensaje)
        {
            double valor = 0.0;
            System.Console.Write(mensaje);
            valor = Double.Parse(System.Console.ReadLine());
            return (valor);
        }
    }
}