using System;

using System;
namespace ProgramacionIntermedia
{
    public delegate void Imprimir<T>(T valor);
    public class Delegates
    {
        public Delegates()
        {
        }

        public void ImprimirPantalla(string v)
        {
            Console.WriteLine(v);
        }
        public void ImprimirPantalla(int v)
        {
            Console.WriteLine(v);
        }

        public void EjemploDelegado()
        {
            Imprimir<string> imprimirDel = new Imprimir<string>(ImprimirPantalla);

            imprimirDel("texto a imprimir ");

            Imprimir<int> imprimirDelEntero = new Imprimir<int>(ImprimirPantalla);

        }
        public void EjemploAction()
        {
            Action<string> actionEjemplo = ImprimirPantalla;
        }

        public void EjemploMetodoAnonimo()
        {
            Action<string> actionEjemploAnonimo = delegate (string valor)
            {
                Console.WriteLine(valor);
            };

            actionEjemploAnonimo("valor a imprimir");

            Action<string> actionEjemploAnonimoLambda = v => Console.WriteLine(v);

            actionEjemploAnonimo("valor a imprimir");
        }

        public void EjemploFunc()
        {
            Func<int, string> delegadoFunc1 = v => $"el valor es {v}";
            delegadoFunc1(23);
        }
        public void EjemploFunc2()
        {
            Func<int,int,int>delegadoFunc2 = (v, x) => v * x;
            int resultado = delegadoFunc2(3, 4);
            Console.WriteLine($"El valor es  {resultado}");
        }

        public void EjemploPredicate()
        {
            Predicate<int> mayorDeEdad = v => v >= 18;
            bool isMayorEdad = mayorDeEdad(25);
        }



        
    }
    public class c2
    {
        public void ClaseAlternativa(Action<string> action)
        {
            action("imprimir");
        }
    }


}
