using System;
using System.Windows.Forms;

namespace TallerParcial2
{
    public partial class FormularioCalcularMonedas : Form
    {
        public FormularioCalcularMonedas()
        {
            InitializeComponent();
        }

        private void btnCalcularConversion_Click(object sender, EventArgs e)
        {
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
                double valorOrigen = Double.Parse(txtOrigen.Text);
                double tasaCambio = Double.Parse(txtTasa.Text);
                string origen = cbxOrigen.SelectedItem.ToString();
                string destino = cbxDestino.SelectedItem.ToString();
                if (origen == destino)
                {
                    throw new InvalidOperationException("La moneda origen y destino son las mismas. No se puede convertir");
                }
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
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtOrigen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            try
            {
                double x = Double.Parse(txtOrigen.Text);
                errorProvider1.SetError(txtOrigen, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtOrigen, "Not a double value.");
            }
        }
    }
}