using System;
namespace ProgramacionIntermedia
{
    internal static class StringExtension
    {
        public static string PrimeraLetraMayuscula(this string frase)
        {
            char primeraLetra = char.ToUpper(frase[0]);
            string restoFrase = frase.Substring(1);
            return primeraLetra + restoFrase;
        }

    }
}
