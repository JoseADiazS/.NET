namespace AppInterfaces
{
    public class Portugues : Idiomas
    {
        public string traducir(string fraseTraducir)
        {
            fraseTraducir = fraseTraducir.ToLower();
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