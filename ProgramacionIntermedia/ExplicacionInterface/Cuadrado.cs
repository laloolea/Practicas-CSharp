using System;
namespace ExplicacionInterface
{
    public class Cuadrado : IPieza
    {
        readonly decimal Lado;
        public Cuadrado(int lado)
        {
            Lado = lado;
        }
        public decimal Area()
        {
            return Lado * Lado;
        }

        public decimal Perimetro()
        {
            return Lado * 4;
        }
    }
}
