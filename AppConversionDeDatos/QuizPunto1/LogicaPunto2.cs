namespace Quiz
{
    internal class LogicaPunto2
    {
        public string palabra = "";
        public int inicio = 0;
        public int fin = 0;
        public bool error = false;

        public int tamañoPalabra(string palabra)
        {
            return palabra.Length;
        }

        public bool esPalindroma(string palabra)
        {
            string cadena = palabra;
            int inicio = 0;
            int fin = tamañoPalabra(palabra) - 1;
            bool error = true;
            while ((inicio < fin) && (error))
            {
                if (cadena[inicio] == cadena[fin])
                {
                    inicio++;
                    fin--;
                }
                else
                {
                    error = false;
                }
            }
            return error;
        }
    }
}