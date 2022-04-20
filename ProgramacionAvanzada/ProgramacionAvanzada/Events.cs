using System;
namespace ProgramacionAvanzada
{
    public class EditorCalculadora
    {

        public delegate void EjemploDelegado();
        public event EjemploDelegado ejemploEvento;//Conviertes el delegado event 


        public void Suma(int a,int b)
        {
            if (ejemploEvento != null)
            { 

                ejemploEvento();
                Console.WriteLine($"La suma es  {a + b}");
            }else
            {
                Console.WriteLine("No esta suscrito a los eventos");
            }
        }
        public void Resta(int a, int b)
        {
            if (ejemploEvento != null)
            {
                Console.WriteLine($"La resta es {a - b}");
            }
            else
            {
                Console.WriteLine("No esta suscrito a los eventos");
            }
        }

    }

    public class SuscriptorCalculadoraVirtual
    {
        private EditorCalculadora editor;
        private int A;
        private int B;
        public void EjemploEventHandler()
        {
            Console.WriteLine("La operacion va a ser ejecutada.");

        }
        public void EjemploEventHandler2()
        {
            Console.WriteLine("Este es nuestro segundo evento.");

        }
        public SuscriptorCalculadoraVirtual(int a, int b)
        { 
            editor = new EditorCalculadora();
            A = a;
            B = b;
            //Para subscribirse += y desubscribir -=
            editor.ejemploEvento += EjemploEventHandler;
            editor.ejemploEvento += EjemploEventHandler2;

        }
        public void OperacionSuma()
        { 
            editor.Suma(A, B);
        }
        public void OperacionResta()
        {
            editor.Resta(A, B);
        }

    }
}
