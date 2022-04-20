using System;
using System.Collections.Generic;

namespace ProgramacionIntermedia
{
    public class QueueFIFO
    {
       public static void Execute()
       {
            Queue<string> marcas = new Queue<string>();
            //Add
            marcas.Enqueue("Audi");
            marcas.Enqueue("carro");
            marcas.Enqueue("bmw");

            foreach(string marca in marcas)
            {
                Console.WriteLine(marca);
            }

            //devuelve el primero
            Console.WriteLine($"La primer marca es {marcas.Peek()}");//Audi
            //devuelve el primero y lo quita
            Console.WriteLine($"La primer marca es (otravez)  {marcas.Dequeue()}");//Audi
            //Ahora este es el primero 
            Console.WriteLine($"La segunda marca es {marcas.Peek()}");//carro

            marcas.Clear();
            
        }

    }
}
