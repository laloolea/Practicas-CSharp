using System;
namespace ExplicacionInterface
{
    public interface interfaz1
    {
         void MetodoRepetido();
    }
    public interface interfaz2
    {
            void MetodoRepetido();
    }
    public class EjemploRepeticionMetodo: interfaz1, interfaz2
    {
        public int lalo { get; set; }

    
        void interfaz1.MetodoRepetido()
        {
            throw new NotImplementedException();
        }
        void interfaz2.MetodoRepetido()
        {
            Console.WriteLine("que onda");
        }

    }
}
