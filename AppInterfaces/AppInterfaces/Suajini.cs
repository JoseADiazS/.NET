namespace AppInterfaces
{
    public class Suajini : Idiomas
    {
        public string traducir(string fraseTraducir)
        {
            fraseTraducir = fraseTraducir.ToLower();
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