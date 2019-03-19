using System.Collections.Generic;

namespace TestJuego
{
    internal class LogicaJuego
    {
        private string palabraCodificar;
        private char letraPista;
        private int codigo;

        private int[] codigos =
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
                ,16,17,18,19,20,21,22,23,24,25,26,27,28 };

        private char[] alfabeto =
        {
            'a','b','c','d','e','f','g','h','i','j','k',
            'l','m','n','o','p','q','r','s','t','u','v',
            'w','x','y','z',' '
        };

        private char[] arregloLetras;
        private int[] arregloCodigos;
        private double[] arregloCodificado;

        public string PalabraCodificar { get => palabraCodificar; set => palabraCodificar = value; }
        public char LetraPista { get => letraPista; set => letraPista = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int[] Codigos { get => codigos; set => codigos = value; }
        public char[] Alfabeto { get => alfabeto; set => alfabeto = value; }
        public char[] ArregloLetras { get => arregloLetras; set => arregloLetras = value; }
        public int[] ArregloCodigos { get => arregloCodigos; set => arregloCodigos = value; }
        public double[] ArregloCodificado { get => arregloCodificado; set => arregloCodificado = value; }

        public double[] codificar(string palabraCodificar, char letraPista)
        {
            double[] cadena = encontrarCadena(palabraCodificar);
            List<double> listaBandera = new List<double>();
            int codigoLetraPista = encontrarCodigo(letraPista);
            for (int i = 0; i < palabraCodificar.Length; i++)
            {
                double digitoBandera = ((cadena[i] * codigoLetraPista) / 2);
                listaBandera.Add(digitoBandera);
            }
            double[] resultado = listaBandera.ToArray();
            return resultado;
        }

        public int encontrarCodigo(char letra)
        {
            int codigoDeLetra = -1;
            for (int i = 0; i <= Alfabeto.Length; i++)
            {
                if (letra == Alfabeto[i])
                {
                    codigoDeLetra = Codigos[i];
                    break;
                }
                else
                {
                    codigoDeLetra = -1;
                }
            }
            return codigoDeLetra;
        }

        public double[] encontrarCadena(string palabra)
        {
            List<double> listaBandera = new List<double>();
            for (int i = 0; i < palabra.Length; i++)
            {
                listaBandera.Add(encontrarCodigo(palabra[i]));
            }
            double[] resultado = listaBandera.ToArray();
            return resultado;
        }
    }
}