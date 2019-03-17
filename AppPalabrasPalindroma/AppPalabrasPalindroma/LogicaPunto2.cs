namespace AppPalabrasPalindroma
{
    /**
 * Author Jose Armando Diaz Segura
 * Electiva .NET
 * 2019-1
 *
 * */

    /// <summary>Modelado para aplicación de palabras palindromas</summary>
    public class LogicaPunto2
    {
        /// <summary>  Metedo para determinar el tamaño de una palabra.</summary>
        /// <param name="palabra">  La palabra</param>
        /// <returns>El numero de caracteres que componen la palabra</returns>
        public int tamañoPalabra(string palabra)
        {
            return palabra.Length;
        }

        /// <summary>  Metodo que determina si una palabra es palindroma</summary>
        /// <param name="palabra">  La palabra</param>
        /// <returns>Retorna verdadero si la palabra es palindroma o falso si no lo es.</returns>
        public bool esPalindroma(string palabra)
        {
            string cadena = palabra.ToLower();
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