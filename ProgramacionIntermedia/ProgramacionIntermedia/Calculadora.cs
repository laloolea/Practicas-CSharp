using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacionIntermedia
{
    public /*static*/ class Calculadora
    {
        public static int Suma(int numero1,int numero2)
        {
            return numero1 + numero2;

        }

        public double Media(List<int> listaEnteros)
        {
            return listaEnteros.Average();
        }
       
    }
}
