using System;
using System.Windows.Forms;

/**
 * Taller Parcial #2
 * José Armando Díaz Segura
 * Electiva .NET
 * 2019-1
 * */

namespace TallerParcial2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioCalcularMonedas());
        }
    }
}