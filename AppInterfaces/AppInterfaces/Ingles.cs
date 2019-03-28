namespace AppInterfaces
{
    public class Ingles : Idiomas
    {
        /// <summary>  Metodo que permite obtener una traduccion al ingles de la palabra ingresada</summary>
        /// <param name="fraseTraducir">  La Frase a traducir</param>
        /// <returns>La frase ingresada traducida a ingles</returns>
        public string traducir(string fraseTraducir)
        {
            //Establecer que la frase sea reducida a minusculas
            fraseTraducir = fraseTraducir.ToLower();
            //bandera
            string bandera = "";
            if (fraseTraducir == "bonito dia")
            {
                bandera = "nice day";
            }
            else if (fraseTraducir == "hasta luego")
            {
                bandera = "see you later";
            }
            else if (fraseTraducir == "hola")
            {
                bandera = "hello";
            }
            else if (fraseTraducir == "loco")
            {
                bandera = "crazy";
            }
            else if (fraseTraducir == "salud")
            {
                bandera = "health";
            }

            return bandera;
        }
    }
}