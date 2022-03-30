using System;
namespace ExplicacionInterface
{
    public class TrianguloRectangulo : IPieza
    {
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }

        public decimal Hipotenusa { get; set; }

        public TrianguloRectangulo(decimal ladoA, decimal ladoB)
        {
            LadoA = ladoA;
            LadoB = LadoB;
            Hipotenusa = CalculateHipotenusa(ladoA, ladoB);
        }

        private decimal CalculateHipotenusa(decimal ladoa, decimal ladob)
        {
            return Convert.ToDecimal(Math.Sqrt((double)(ladoa * ladoa + ladob * ladob)));
        }

        public decimal Area()
        {
            return (LadoA * LadoB) / 2;
        }

        public decimal Perimetro()
        {
            return LadoA + LadoB + Hipotenusa;
        }
    }
}
