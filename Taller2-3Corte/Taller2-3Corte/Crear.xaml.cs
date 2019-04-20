using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Lógica de interacción para Crear.xaml
    /// </summary>
    public partial class Crear : Page
    {
        private static Controlador ControladorAccesoDatos;

        public object DialogResult { get; private set; }

        public Crear(string rutaServidor)
        {
            InitializeComponent();
            string connectionString =
                "Data Source=" + rutaServidor + "; Initial Catalog=Northwind; Integrated Security = False; User Id = sa; Password = 12345678; MultipleActiveResult" +
                "Sets = True";
            ControladorAccesoDatos = new Controlador(connectionString);
            var dttest = ControladorAccesoDatos.GetProovedoresV2();
            cbxProovedor.ItemsSource = dttest.DefaultView;
            cbxProovedor.DisplayMemberPath = "CompanyName";
            cbxProovedor.SelectedValuePath = "SupplierID";
            var dttest2 = ControladorAccesoDatos.GetCategoriasV2();
            cbxCategoria.ItemsSource = dttest2.DefaultView;
            cbxCategoria.DisplayMemberPath = "CategoryName";
            cbxCategoria.SelectedValuePath = "CategoryID";
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            bool seInserto = false;

            try
            {
                string nomProducto = txtNombreProducto.Text;
                var proov = (ComboBoxItem)cbxProovedor.SelectedItem;
                int proovedor = GetProovedor(proov.Content.ToString());
                var cat = (ComboBoxItem)cbxCategoria.SelectedItem;
                int categoria = GetCategoria(cat.Content.ToString());
                double precioUnd = Double.Parse(txtPrecioUnitario.Text);
                string cantidadxUnd = txtCantidadxUnidad.Text;
                int undxOrden = Int32.Parse(txtUnidadesxOrden.Text);
                int nivelReorg = Int32.Parse(txtNivelReorg.Text);
                byte estaDescon = EstaDescontinuado();
                MessageBoxResult result = MessageBox.Show("¿Esta seguro que desea almacenar el registro del producto?", "Confirmación Registro", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    seInserto = ControladorAccesoDatos.insertarRegistro(nomProducto, proovedor, categoria, precioUnd, cantidadxUnd, undxOrden, nivelReorg, estaDescon); 
                }
                else if (result == MessageBoxResult.No)
                {
                    MessageBox.Show("No se inserto");
                }
                if (seInserto == true)
                {
                    MessageBox.Show("Se inserto Correctamente");
                }

            }

            catch (NullReferenceException errorInsertar)
            {
                MessageBox.Show("Debe seleccionar un proovedor y categoria");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
           
            
            //Limpiamos los controles
            // this.txt_Name.Text = "";
            //this.sel_Departamentos.SelectedIndex = 0;


        }

        private Byte EstaDescontinuado()
        {
            Byte bandera = 0;
            if ((bool)rbtnSi.IsChecked)
            {
                bandera = 1;
            }else if ((bool)rbtnNo.IsChecked)
            {
                bandera = 0;
            }
            return bandera;
        }
        private int GetProovedor(string proovedorName)
        {
            int bandera = 0;
            switch (proovedorName)
            {
                case "Aux joyeux eccl? siastiques":
                    bandera = 18;
                    break;
                case "Bigfoot Breweries":
                    bandera = 16;
                    break;
                case "Cooperativa de Quesos 'Las Cabras'":
                    bandera = 5;
                    break;
                case "Escargots Nouveaux":
                    bandera = 27;
                    break;
                case "Exotic Liquids":
                    bandera = 1;
                    break;
                case "For? ts d'?rables":
                    bandera = 29;
                    break;
                case "Formaggi Fortini s.r.l.":
                    bandera = 14;
                    break;
                case "Gai p?turage":
                    bandera = 28;
                    break;
                case "G'day, Mate":
                    bandera = 24;
                    break;
                case "Grandma Kelly's Homestead":
                    bandera = 3;
                    break;
                case "Heli S?? waren GmbH & Co.KG":
                    bandera = 11;
                    break;
                case "Karkki Oy":
                    bandera = 23;
                    break;
                case "Leka Trading":
                    bandera = 20;
                    break;
                case "Lyngbysild":
                    bandera = 21;
                    break;
                case "Ma Maison":
                    bandera = 25;
                    break;
                case "Mayumi's":
                    bandera = 6;
                    break;
                case "New England Seafood Cannery":
                    bandera = 19;
                    break;
                case "New Orleans Cajun Delights":
                    bandera = 2;
                    break;
                case "Nord - Ost - Fisch Handelsgesellschaft mbH":
                    bandera = 13;
                    break;
                case "Norske Meierier":
                    bandera = 15;
                    break;
                case "Pasta Buttini s.r.l.":
                    bandera = 26;
                    break;
                case "Pavlova, Ltd.":
                    bandera = 7;
                    break;
                case "PB Kn?ckebr? d AB":
                    bandera = 9;
                    break;
                case "Plutzer Lebensmittelgro? m?rkte AG":
                    bandera = 12;
                    break;
                case "Refrescos Americanas LTDA":
                    bandera = 10;
                    break;
                case "Specialty Biscuits, Ltd.":
                    bandera = 8;
                    break;
                case "Svensk Sj?f? da AB":
                    bandera = 17;
                    break;
                case "Tokyo Traders":
                    bandera = 4;
                    break;
                case "Zaanse Snoepfabriek":
                    bandera = 22;
                    break;
            }
            return bandera;
           
        } 
        private int GetCategoria(string nombreCategoria)
        {
            int bandera = 0;
            switch (nombreCategoria)
            {
                case "Bebidas":
                    bandera = 1;
                    break;
                case "Carnes / Avicolas":
                    bandera = 1;
                    break;
                case "Comida de Mar":
                    bandera = 1;
                    break;
                case "Condimentos":
                    bandera = 1;
                    break;
                case "Confecciones":
                    bandera = 1;
                    break;
                case "Deshidratados":
                    bandera = 1;
                    break;
                case "Granos / Cereales":
                    bandera = 1;
                    break;
                case "Lacteos":
                    bandera = 1;
                    break;
            }
            return bandera;
        }
    }
}
