using System;
using System.Collections.Generic;
using System.Data;
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

namespace Taller2_3Corte
{
    /// <summary>
    /// Lógica de interacción para Consultar.xaml
    /// </summary>
    public partial class Consultar : Page
    {
        private static Controlador ControladorAccesoDatos;
        public Consultar(string rutaServidor)
        {
            InitializeComponent();
            string connectionString =
                "Data Source=" + rutaServidor + "; Initial Catalog=Northwind; Integrated Security = False; User Id = sa; Password = 12345678; MultipleActiveResult" +
                "Sets = True";
            ControladorAccesoDatos = new Controlador(connectionString);
            var dttest = ControladorAccesoDatos.GetProovedoresV2();
            cbxProovedores.ItemsSource = dttest.DefaultView;
            cbxProovedores.DisplayMemberPath = "CompanyName";
            cbxProovedores.SelectedValuePath = "SupplierID";
        }

        private void BtnConsultaProovedores_Click(object sender, RoutedEventArgs e)
        {
            var dttest = ControladorAccesoDatos.GetListaProovedores();
            dtaGridResultado.ItemsSource = dttest.DefaultView;
        }

        private void BtnConsultaCategorias_Click(object sender, RoutedEventArgs e)
        {
            var dttest = ControladorAccesoDatos.GetListaCategorias();
            dtaGridResultado.ItemsSource = dttest.DefaultView;
        }

        private void BtnConsultaProductos_Click(object sender, RoutedEventArgs e)
        {
            var dttest = ControladorAccesoDatos.GetListaProductos();
            dtaGridResultado.ItemsSource = dttest.DefaultView;
        }

        private void BtnConsultaPunto9_Click(object sender, RoutedEventArgs e)
        {
            var dttest = ControladorAccesoDatos.GetConsultaPunto9();
            dtaGridResultado.ItemsSource = dttest.DefaultView;
        }

        private void BtnConsultaProovedorEspec_Click(object sender, RoutedEventArgs e)
        {
            DataRowView sel = (DataRowView)cbxProovedores.SelectedItem;
            string proovedor = (String)sel.Row[0];
            var dttest = ControladorAccesoDatos.GetProovEspec(proovedor);
            dtaGridResultado.ItemsSource = dttest.DefaultView;
        }
    }
}
