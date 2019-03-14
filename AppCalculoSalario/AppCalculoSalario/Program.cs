using System;

/**
 * Taller #2 del segundo corte de C#
 * Aplicación calculo de salario de un empleado
 * José Armando Diaz Segura
 * Cristian Camilo Ricaurte
 *
 * */

namespace AppCalculoSalario
{
    internal class Program
    {
        public void ImprimirMenu()
        {
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("MENÚ DE OPCIONES DE SOBRECARGA");
            System.Console.WriteLine("1.  Ingresar datos del empleado");
            System.Console.WriteLine("2.  Calcular sueldo bruto del empleado");
            System.Console.WriteLine("3.  Calcular Deduccion por Salud del empleado");
            System.Console.WriteLine("4.  Calcular Deduccion por Pensión del empleado");
            System.Console.WriteLine("5.  Calcular Deduccion por Riesgos Profesionales del empleado");
            System.Console.WriteLine("6.  Calcular total de deducciones del empleado");
            System.Console.WriteLine("7.  Calcular sueldo total del emplado");
            System.Console.WriteLine("8.  Salir");
            System.Console.WriteLine("********************************************");
        }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Program controladorAplicacion = new Program();
            CalculoDeducciones deducciones = new CalculoDeducciones(0, 0, 0, 0, 0);
            Empleado empleado = new Empleado("", 0, 0, 0);
            int seleccion;

            //Lectura de datos
            System.Console.WriteLine("************************************************************");
            System.Console.WriteLine("************************************************************");
            System.Console.WriteLine("************************************************************");
            System.Console.WriteLine("APLICACIÓN C# PARA CALCULAR EL SUELDO DE UN EMPLEADO");
            do
            {
                System.Console.WriteLine("Menu de Opciones");
                controladorAplicacion.ImprimirMenu();
                System.Console.Write("Digite una Opción: ");
                seleccion = Int32.Parse(System.Console.ReadLine());
                if (seleccion != 8)
                {
                    switch (seleccion)
                    {
                        case 1:
                            System.Console.Write("Ingrese el nombre del empleado: ");
                            empleado.Nombre = System.Console.ReadLine();
                            empleado.NumHorasMes = deducciones.leerValorReal("Ingrese el numero de horas trabajadas al mes por: " + empleado.Nombre + " ");
                            empleado.ValHora = deducciones.leerValorReal("Ingrese el valor de la hora de trabajo del empleado: " + empleado.Nombre + " ");
                            break;

                        case 2:
                            empleado.GetSueldoBruto();
                            //Impresion sueldo bruto
                            System.Console.WriteLine("El nombre es  " + empleado.Nombre + " ");
                            System.Console.WriteLine("La cantidad de horas trabajadas por " + empleado.Nombre + " fue: " + empleado.NumHorasMes + " ");
                            System.Console.WriteLine("El sueldo bruto es: " + empleado.SueldoBruto);
                            break;

                        case 3:
                            deducciones.Sueldo = empleado.SueldoBruto;
                            deducciones.Salud = deducciones.CalculoSalud();
                            System.Console.WriteLine("La deduccion por Salud fue: " + deducciones.Salud);
                            break;

                        case 4:
                            deducciones.Pension = deducciones.CalculoPension(deducciones.leerValorReal("Digite el valor por pension "));
                            System.Console.WriteLine("La deduccion por Pension fue: " + deducciones.Pension);
                            break;

                        case 5:
                            System.Console.WriteLine("Seleccione el rango de riesgo profesional del empleado " + empleado.Nombre);
                            System.Console.WriteLine("Los rangos son: 1 , 2 o 3");
                            seleccion = Int32.Parse(System.Console.ReadLine());
                            deducciones.CalculoRiesgos(seleccion);
                            System.Console.WriteLine("La deduccion por Riesgos Profesionales fue: " + deducciones.RiesgosPro);
                            break;

                        case 6:
                            System.Console.WriteLine("El total de deducciones fue: " + deducciones.TotalDeducciones);
                            break;

                        case 7:
                            double Sueldototal = empleado.GetSueldoTotal(deducciones.TotalDeducciones);
                            System.Console.WriteLine("El sueldo total del empleado " + empleado.Nombre + " es: " + Sueldototal);
                            break;
                    }
                }
            } while (seleccion != 8);
        }
    }
}