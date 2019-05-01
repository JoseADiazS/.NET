using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego.Models
{
    public class Decodificador
    {
        int[] codigos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28};
        char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'ñ','o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',' '};

        public double[] obtenerCadena(string cadena)
        {
            double bandera2 = 0.0;
            string bandera3 = "";
            List<Double> bandera = new List<double>();
            for(int i = 0; i < cadena.Length; i++)
            {
                
                if (cadena[i] >= '0' && cadena[i] <= '9' || cadena[i] == ',')
                {
                    bandera3 += cadena[i];
                }else if(cadena[i] == '-')
                {
                    bandera2 = Double.Parse(bandera3);
                    bandera.Add(bandera2);
                    bandera2 = 0.0;
                    bandera3 = "";
                }
            }
            return bandera.ToArray();
        }

        public string obtenerPalabra(double[] cadena,char letraPista)
        {
            string bandera = "";
            double letrapista = getCodigoLetra(letraPista);
            for(int i = 0;i < cadena.Length; i++)
            {
                double codigo = ((2 * getCodigoLetra2(cadena[i], letraPista)) - letrapista);
                bandera += getCodigoLetra2(codigo, letraPista);
            }
            return bandera;
        }
        public double getCodigoLetra(char letra)
        {
            double bandera = 0;
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (letra == alfabeto[i])
                {
                    bandera = codigos[i];
                    break;
                }
            }
            return bandera;
        }
        public char getCodigoLetra2(double letracodificada,char letrapista)
        {
            double letraPista = getCodigoLetra(letrapista);
            char bandera = 'a';
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (letracodificada == codigos[i])
                {
                    bandera = alfabeto[i];
                }
            }
            return bandera;
        }
    }
}