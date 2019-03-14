using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConjuntoPersonas
{
    class Modelado
    {

        

        public (string, int) GetPersonaMasJoven(List<Persona> ArregloPersonas)
        {
            //Bandera
            var bandera = ("", 1000);
            for (int i = 0; i < ArregloPersonas.Count; i++)
            {
                if ( ArregloPersonas[i].Edad < bandera.Item2 )
                {
                    bandera = (ArregloPersonas[i].Nombre, ArregloPersonas[i].Edad);
                }
            }
            return bandera;
        }

        public (string,int) GetPersonaMasVieja(List<Persona> ArregloPersonas)
        {
            //Bandera
            var bandera = ("", 0);
            for (int i = 0; i < ArregloPersonas.Count; i++)
            {
                if(ArregloPersonas[i].Edad > bandera.Item2)
                {
                    bandera = (ArregloPersonas[i].Nombre, ArregloPersonas[i].Edad);
                }
            }
            return bandera;
        }
        public double GetPromedioPersonas(List<Persona> ArregloPersonas)
        {
            //Suma
            int Suma = 0;
            for (int i = 0; i < ArregloPersonas.Count; i++)
            {
                Suma += ArregloPersonas[i].Edad;
            }
            return Suma / ArregloPersonas.Count;
        }

        public IOrderedEnumerable<Persona> OrdenarArregloEdades(List<Persona> ArregloPersonas)
        {
            var listSort = from element in ArregloPersonas orderby element.Edad select element;
            return listSort;
        }
    }
}
