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
            try
            {
                Circulo circulo = new Circulo();
                Cuadrado cuadrado = new Cuadrado();
                Rectangulo rectangulo = new Rectangulo();
                circulo.Radio = Double.Parse(txtRadio.Text);
                cuadrado.Lado = Double.Parse(txtLado.Text);
                rectangulo.Ancho = Double.Parse(txtAncho.Text);
                rectangulo.Largo = Double.Parse(txtLargo.Text);
                var color = (ComboBoxItem)cbxColor.SelectedItem;
                string colorName = color.Content.ToString();
                Graficas graficas = new Graficas(circulo.Radio, cuadrado.Lado, rectangulo.Ancho, rectangulo.Largo, obtenerColor(colorName));
                this.NavigationService.Navigate(graficas);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Debe seleccionar un color");
            }

        }
        private Color obtenerColor(string color)
        {
            Color colorEscogido = Colors.White;

            switch (color)
            {
                case "Rojo":
                    colorEscogido = Colors.Red;
                    break;
                case "Verde":
                    colorEscogido = Colors.Green;
                    break;
                case "Amarillo":
                    colorEscogido = Colors.Yellow;
                    break;
                case "Negro":
                    colorEscogido = Colors.Black;
                    break;
                case "Azul":
                    colorEscogido = Colors.Blue;
                    break;
            }
            return (colorEscogido);
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtAncho.Text = "";
            txtLargo.Text = "";
            txtLado.Text = "";
            txtRadio.Text = "";
            cbxColor.SelectedIndex = -1;
        }
    }
}
