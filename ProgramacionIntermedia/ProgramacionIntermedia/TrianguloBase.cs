using System;
namespace ProgramacionIntermedia
{
    public abstract class TrianguloBase
    {
        public abstract decimal Perimtro();
        public abstract decimal Area();

        public double CalcularAreaTrianguloConHipotenusa(int lado, int hipotenusa)
        {
            double ladob = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2));
            return lado * ladob / 2;
        }

    }

    public class Escaleno : TrianguloBase
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimtro()
        {
            throw new NotImplementedException();
        }
    }
    public class Acutangulo : TrianguloBase
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimtro()
        {
            throw new NotImplementedException();
        }

        public int CalcularAreaEnBaseAngulos(int anguloA,int anguloB,int anguloC,int ladoA)
        {
            return 1;
        }
    }

}
