using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TallerWPF
{
    /// <summary>
    /// Lógica de interacción para ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        private void BtnGraficar_Click(object sender, RoutedEventArgs e)
        {
            Circulo circulo = new Circulo();
            Cuadrado cuadrado = new Cuadrado();
            Rectangulo rectangulo = new Rectangulo();

            circulo.Radio = Double.Parse(txtRadio.Text);
            cuadrado.Lado = Double.Parse(txtLado.Text);
            rectangulo.Ancho = Double.Parse(txtAncho.Text);
            rectangulo.Largo = Double.Parse(txtLargo.Text);
        }
    }
}
