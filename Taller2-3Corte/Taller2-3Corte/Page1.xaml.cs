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
using Taller2_3Corte;
//Author Jose Armando Diaz Segura
namespace TallerADOyWPF
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, RoutedEventArgs e)
        {
            Crear crear = new Crear(txtRutaServidor.Text);
            this.NavigationService.Navigate(crear);
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            Consultar consultar = new Consultar(txtRutaServidor.Text);
            this.NavigationService.Navigate(consultar);
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            Modificar modificar = new Modificar(txtRutaServidor.Text);
            this.NavigationService.Navigate(modificar);
        }
    }
}
