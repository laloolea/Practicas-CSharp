using System;
using System.Collections.Generic;

namespace ProgramacionIntermedia
{
    public class Lista
    {
       public static void Execute()
        {
            //Inizializacion, asignacion valores
            List<string> firstList = new List<string>()
            {
                "Opel",
                "BMW"
            };


            List<string> marcas = new List<string>();
            //Añadir elemento
            marcas.Add("Audi");
            //Añadir una lista a otra 
            marcas.AddRange(firstList);

            //Acceder por indice
            Console.WriteLine(marcas[0]);
            //iterar
            foreach(string item in marcas)
            {
                Console.WriteLine(item);
            }

            IReadOnlyList<string> readonlyMarcas = marcas;
            IList<string> IListMarcas = marcas;


            // insertar en index especifico
            marcas.Insert(1, "carro");

            //remove
            marcas.RemoveAt(0); // elimina audi
            marcas.Remove("soda");//eliina soda


            //Lista ordenada, ICompare  interfazimplementada
            SortedList<int, string> listaCochesOrdenada = new SortedList<int, string>()
            {
                {3,"bmw" },{1,"carro" },{2,"ford"}
            };
            foreach(var item in listaCochesOrdenada)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
