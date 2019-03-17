namespace Quiz
{
    /**
 * Author Jose Armando Diaz Segura
 * Electiva .NET
 * 2019-1
 *
 * */

    /// <summary>Modelado logica para aplicacion de conversión de datos</summary>
    internal class LogicaPunto1
    {
        /// <summary>Convierte el  numbero largo a entero.</summary>
        /// <param name="valLong">El valor long.</param>
        /// <returns>El valor long transformado en Entero</returns>
        public int ConvertirNumLongToInt(long valLong)
        {
            var LongToIntvalLong = (int)valLong;
            if (LongToIntvalLong < 0)
            {
                return -1;
            }
            return LongToIntvalLong;
        }

        /// <summary>  Convierte el numero largo en real</summary>
        /// <param name="valLong">  El valor largo</param>
        /// <returns>El valor largo convertido en valor real</returns>
        public double ConvertirNumLongToDouble(long valLong)
        {
            var LongToDouble = (double)valLong;
            return LongToDouble;
        }

        /// <summary>  Convierte el numero entero en largo</summary>
        /// <param name="valEntero">  El valor entero</param>
        /// <returns>El valor entero convertido en largo</returns>
        public long ConvertirNumIntToLong(int valEntero)
        {
            var EnteroToLong = (long)valEntero;
            return EnteroToLong;
        }

        /// <summary>  Convierte el numero entero en real</summary>
        /// <param name="valEntero">  El valor entero</param>
        /// <returns>El valor entero convertido en real</returns>
        public double ConvertirNumIntToDouble(int valEntero)
        {
            var EnteroToDouble = (double)valEntero;
            return EnteroToDouble;
        }

        /// <summary>  Convierte el numero real en largo</summary>
        /// <param name="valDouble">  el valor real</param>
        /// <returns>El valor real convertido en largo</returns>
        public long ConvertirNumDoubleToLong(double valDouble)
        {
            var DoubleToLong = (long)valDouble;
            return DoubleToLong;
        }

        /// <summary>  Convierte el numero real en entero</summary>
        /// <param name="valDouble">  El valor real</param>
        /// <returns>El valor real convertido en entero</returns>
        public int ConvertirNumDoubleToInt(double valDouble)
        {
            var DoubleToInt = (int)valDouble;
            return DoubleToInt;
        }
    }
}