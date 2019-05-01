using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego.Models
{
    public class Codificador
    {
        
        int[] codigos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28};
        char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'ñ','o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',' '};
        

        public char[] convertirPalabraEnCodigos(string palabra)
        {
            char[] arregloLetras = null;
            int i = 0;
            char caracter = '\0';
            try
            {
                arregloLetras = new char[palabra.Length];
                for(i = 0; i < palabra.Length; i++)
                {
                    caracter = palabra[i];
                    arregloLetras[i] = caracter;
                }
            }
            catch (Exception errorConvertirPalabraEnCodigos)
            {
                Console.WriteLine("Error en convertir palabra en codigos: " 
                    + errorConvertirPalabraEnCodigos.Message);
                char[] vacio = new char[palabra.Length];
                return vacio;
            }
            return (arregloLetras);
        }

        public double codificarLetra(char letra, char letraPista)
        {
            double codLetra = getCodigoLetra(letra);
            double codLetraPista = getCodigoLetra(letraPista);
            return ((codLetra + codLetraPista) / 2);

        }
        public double getCodigoLetra(char letra)
        {
            double bandera = 0;
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (letra == alfabeto[i])
                {
                    bandera = codigos[i];
                }
            }
            return bandera;
        }
        public double[] codificar(string palabra,char letraPista)
        {
            char[] arregloChar = convertirPalabraEnCodigos(palabra);
            double[] arregloNums = new double[palabra.Length];
            for(int i = 0;i < arregloChar.Length; i++)
            {
                arregloNums[i] = codificarLetra(arregloChar[i], letraPista);
            }
            return arregloNums;
        }
        public string cadenaCodigo(double[] cadena)
        {
            string bandera ="";
            foreach (double i in cadena)
            {
                bandera += i + "-" ;
            }
            return bandera;
        }
    }
}