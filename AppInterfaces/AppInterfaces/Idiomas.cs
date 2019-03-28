namespace AppInterfaces
{
    public interface Idiomas
    {
        /// <summary>  Metodo para obtener la frase traducida</summary>
        /// <param name="fraseTraducir">  La frase a traducir.</param>
        /// <returns>La frase traducida</returns>
        string traducir(string fraseTraducir);
    }
}