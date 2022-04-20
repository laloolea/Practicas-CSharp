using System;
using System.Collections.Generic;

namespace ProgramacionIntermedia
{
    public class Dictionary
    {
        public static void Execute()
        {
            //Inizialisacion
            Dictionary<string, string> comunidadesCapitales = new Dictionary<string, string>()
            {
                { "Hermosillo","Sonora"},
                {"La paz","Baja" }
            };

            //Añadir valores
            comunidadesCapitales.TryAdd("Aragon", "Toledo");//devuelve booleano para comprobar si la key que uqieres insertar no esta dentro

            //Acceder valores
            Console.WriteLine(comunidadesCapitales["Hermosillo"]); //Devuelve Sonora


            //KeyValuePair<string, string> resultado = comunidadesCapitales.ElementAt(0);
            //Console.WriteLine(resultado.Value); //Devuelve Zaragoza


            //Acceder correctamente a los valores
            if(comunidadesCapitales.TryGetValue("Aragon", out string resultadoCapital))
            {
                Console.WriteLine(resultadoCapital);
            }
            else
            {
                Console.WriteLine("El parametor no existe");
            }

            //Actualizar valores de un diccionario
            if (comunidadesCapitales.ContainsKey("Aragon"))
            {
                comunidadesCapitales["Aragon"] = "Teruel existe";
            }   
            //Delete
            comunidadesCapitales.Remove("Aragon");
            comunidadesCapitales.Clear();
        }
    }
}
