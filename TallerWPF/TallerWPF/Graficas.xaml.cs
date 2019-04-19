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
    /// Lógica de interacción para Graficas.xaml
    /// </summary>
    public partial class Graficas : Page
    {
        public Graficas(double radio,double lado,double ancho,double largo,Color color)
        {
            InitializeComponent();
            this.circulo.Height = radio;
            this.circulo.Width = radio;
            this.circulo.Fill = new SolidColorBrush(color);
            this.cuadrado.Height = lado;
            this.cuadrado.Height = lado;
            this.cuadrado.Fill = new SolidColorBrush(color);
            this.rectangulo.Height = largo;
            this.rectangulo.Width = ancho;
            this.rectangulo.Fill = new SolidColorBrush(color);
        }
    }
}
