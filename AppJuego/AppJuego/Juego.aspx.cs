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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCodificarText_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabraCodificar.Text;
            char letraPista = char.Parse(dropListLetraPistaCod.SelectedValue);            
            double[] conversion = codificador.codificar(palabra, letraPista);
            mensajeCodificado.Text = codificador.cadenaCodigo(conversion);
           
        }

        protected void btnDecodificarText_Click(object sender, EventArgs e)
        {
            string cadena = cadenaADecodificar.Text;
            char letraPista = char.Parse(dropListLetraPistaDecod.SelectedValue);
            double[] cadena2 = decodificador.obtenerCadena(cadena);
            string codigo = decodificador.obtenerPalabra(cadena2,letraPista);
            txtDecodificacion.Text = codigo;
        }
    }
}