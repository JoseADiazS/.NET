namespace AppInterfaces
{
    public class Suajini : Idiomas
    {
        /// <summary>  Metodo que permite obtener una traduccion al Suajini de la palabra ingresada</summary>
        /// <param name="fraseTraducir">  La Frase a traducir</param>
        /// <returns>La frase ingresada traducida a Suajini </returns>
        public string traducir(string fraseTraducir)
        {
            //Establecer que la frase sea reducida a minusculas
            fraseTraducir = fraseTraducir.ToLower();
            //Bandera
            string bandera = "";
            if (fraseTraducir == "bonito dia")
            {
                bandera = "nice siku";
            }
            else if (fraseTraducir == "hasta luego")
            {
                bandera = "kuona baadaye";
            }
            else if (fraseTraducir == "hola")
            {
                bandera = "hujambo";
            }
            else if (fraseTraducir == "loco")
            {
                bandera = "mambo";
            }
            else if (fraseTraducir == "salud")
            {
                bandera = "afya";
            }

            return bandera;
        }
    }
}