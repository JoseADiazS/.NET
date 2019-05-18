using AppJuego.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AppJuego
{
    public partial class Juego : System.Web.UI.Page
    {
        Codificador codificador = new Models.Codificador();
        Decodificador decodificador = new Models.Decodificador();
        //Listener listener = new Listener();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //listener.StartListening();
        }

        protected void btnCodificarText_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabraCodificar.Text;
            char letraPista = char.Parse(dropListLetraPistaCod.SelectedValue);            
            double[] conversion = codificador.codificar(palabra, letraPista);
            var cadena = codificador.cadenaCodigo(conversion);
            mensajeCodificado.Text = cadena;
            
            

            //cadenaADecodificar.Text;

        }

        protected void btnDecodificarText_Click(object sender, EventArgs e)
        {
            string cadena = cadenaADecodificar.Text;
           
            char letraPista = char.Parse(dropListLetraPistaDecod.SelectedValue);
            double[] cadena2 = decodificador.obtenerCadena(cadena);
            string codigo = decodificador.obtenerPalabra(cadena2,letraPista);
            txtDecodificacion.Text = codigo;
            
        }

        protected void btnLimpiarDeco_Click(object sender, EventArgs e)
        {
            cadenaADecodificar.Text = "";
            dropListLetraPistaDecod.SelectedIndex = -1;
            mensajeCodificado.Text = "";
        }

        protected void btnLimpiarCodificador_Click(object sender, EventArgs e)
        {
            txtPalabraCodificar.Text = "";
            dropListLetraPistaCod.SelectedIndex = -1;
            cadenaADecodificar.Text = "";
        }
    }
}