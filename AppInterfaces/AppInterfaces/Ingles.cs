namespace AppInterfaces
{
    public class Ingles : Idiomas
    {
        public string traducir(string fraseTraducir)
        {
            fraseTraducir = fraseTraducir.ToLower();
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