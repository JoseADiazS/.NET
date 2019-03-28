namespace AppInterfaces
{
    public class Portugues : Idiomas
    {
        /// <summary>  Metodo que permite obtener una traduccion a portugues de la palabra ingresada</summary>
        /// <param name="fraseTraducir">  La Frase a traducir</param>
        /// <returns>La frase ingresada traducida al portugues</returns>
        public string traducir(string fraseTraducir)
        {
            //Establecer que la frase sea reducida a minusculas
            fraseTraducir = fraseTraducir.ToLower();
            //Bandera
            string bandera = "";
            if (fraseTraducir == "bonito dia")
            {
                bandera = "bom dia";
            }
            else if (fraseTraducir == "hasta luego")
            {
                bandera = "até logo";
            }
            else if (fraseTraducir == "hola")
            {
                bandera = "olá";
            }
            else if (fraseTraducir == "loco")
            {
                bandera = "louco";
            }
            else if (fraseTraducir == "salud")
            {
                bandera = "saúde";
            }

            return bandera;
        }
    }
}