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
    public partial class FormularioCalcularMonedas : Form
    {
        /// <summary>Initializes a new instance of the <see cref="FormularioCalcularMonedas"/> class.</summary>
        public FormularioCalcularMonedas()
        {
            InitializeComponent();
        }

        /// <summary>Handles the Click event of the btnCalcularConversion control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="InvalidOperationException">La moneda origen y destino son las mismas. No se puede convertir</exception>
        /// <exception cref="ArgumentException">Debe seleccionar una dirección de conversión</exception>
        /// <exception cref="NullReferenceException">Debe seleccionar una divisa de origen y destino para la conversión</exception>
        /// /// <exception cref="FormatException">El valor ingresado deber ser un numero</exception>
        private void btnCalcularConversion_Click(object sender, EventArgs e)
        {
            //Creacion de variables e instanciamientos
            InterfaceConversionMonedas conversion;
            DolaresAmericanos dolares = new DolaresAmericanos();
            Euros euros = new Euros();
            PesosColombianos pesos = new PesosColombianos();
            YenesJaponeses yenes = new YenesJaponeses();
            Yuanes yuanes = new Yuanes();
            double banderaConversion = 0.0;
            string valBitcoins = txtValBitcoins.Text;
            try
            {
                //Creacion de variables y llamado a elementos del formulario
                double valorOrigen = Double.Parse(txtOrigen.Text);
                double tasaCambio = Double.Parse(txtTasa.Text);
                string origen = cbxOrigen.SelectedItem.ToString();
                string destino = cbxDestino.SelectedItem.ToString();
                //Validacion para que las divisas de conversion sean distintas
                if (origen == destino)
                {
                    throw new InvalidOperationException("La moneda origen y destino son las mismas. No se puede convertir");
                }
                //Validacion de la seleccion de una direccion de conversion
                if (!OD.Checked && !DO.Checked)
                {
                    throw new ArgumentException("Debe seleccionar una dirección de conversión");
                }
                //Validacion de la ruta seleccionada
                //Conversion de Divisa Origen a Divisa Destino
                if (OD.Checked)
                {
                    if (origen == "Dólares Americanos")
                    {
                        conversion = (DolaresAmericanos)dolares;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "OD");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    else if (origen == "Euros")
                    {
                        conversion = (Euros)euros;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "OD");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    else if (origen == "Yuanes (Renminbi)")
                    {
                        conversion = (Yuanes)yuanes;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "OD");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    else if (origen == "Yenes Japoneses")
                    {
                        conversion = (YenesJaponeses)yenes;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "OD");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    else if (origen == "Pesos Colombianos")
                    {
                        conversion = (PesosColombianos)pesos;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "OD");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    txtOrigenSalida.Text = origen;
                    txtDestinoSalida.Text = destino;
                }
                //Conversion de Divisa Destino a Divisa Origen
                else if (DO.Checked)
                {
                    if (origen == "Dólares Americanos")
                    {
                        conversion = (DolaresAmericanos)dolares;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "DO");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    else if (origen == "Euros")
                    {
                        conversion = (Euros)euros;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "DO");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    else if (origen == "Yuanes (Renminbi)")
                    {
                        conversion = (Yuanes)yuanes;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "DO");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    else if (origen == "Yenes Japoneses")
                    {
                        conversion = (YenesJaponeses)yenes;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "DO");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    else if (origen == "Pesos Colombianos")
                    {
                        conversion = (PesosColombianos)pesos;
                        banderaConversion = conversion.calcularConversionMoneda(valorOrigen, tasaCambio, "DO");
                        txtValBitcoins.Text = conversion.calcularConversionMonedaBitcoins(valorOrigen).ToString();
                    }
                    txtOrigenSalida.Text = destino;
                    txtDestinoSalida.Text = origen;
                }
                txtDestinoConversion.Text = banderaConversion.ToString("0.##");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La moneda origen y destino son las mismas. No se puede convertir");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El valor ingresado deber ser un numero");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Debe seleccionar una divisa de origen y destino para la conversión");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Debe seleccionar una dirección de conversión");
            }
        }

        /// <summary>Handles the Click event of the btnLimpiarCampos control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>Handles the Click event of the btnAcercaDe control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fabricado por Jose Armando Diaz Segura \nTodos los derechos reservados - " + DateTime.Now.Year);
        }

        /// <summary>Handles the Click event of the btnSalir control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}