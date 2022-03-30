using System;
namespace ProgramacionIntermedia
{
    public class Moto:Vehiculo
    { 

        public int Cilindrada { get;set;}
        public Moto(string marca, string modelo, int cilindrada):base(marca,modelo)
        {
            Cilindrada = cilindrada;
        }

        public new void Arrancar()
        {
            Console.WriteLine("Arrancar moto");

        }
        public sealed override  void Pitar()
        {
            Console.WriteLine("La moto a pitado");
        }
    }
    public class triciclo : Moto
    {

        public triciclo(string marca, string modelo, int cilindrada) : base(marca, modelo,cilindrada)
        {
            Cilindrada = cilindrada;
        }

        public new void Arrancar()
        {
            Console.WriteLine("Arrancar moto");

        }
        //public override void Pitar()
        //{
        //    Console.WriteLine("La moto a pitado");
        //}
    }
}
