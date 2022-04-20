using System;
using System.Collections.Generic;

namespace ProgramacionIntermedia.Colecciones
{
    public class Stack
    {
        public static void Execute()
        {
            Stack<string> marcas = new Stack<string>();


            marcas.Push("audi");
            marcas.Push("Opel");
            marcas.Push("bmw");


            foreach(string marca in marcas)
            {
                Console.WriteLine(marca);
            }

            Console.WriteLine($"La ultima marca insertada es {marcas.Peek()}");//Devuelve el primero (ultima insertada) Bmw
            Console.WriteLine($"La ultima marca insertada (otra vez)es {marcas.Pop()}");//Devuelve el primero bmw
            Console.WriteLine($"La penultima marca insertada es {marcas.Pop()}");//Devuelve la nueva primera //Opel


        }
    }
}
