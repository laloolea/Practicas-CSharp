using System;
namespace Dia2
{
    public class Moto:Vehiculo
    {
        //:base para mandarle los parametros al padre
        public Moto(string marca, string modelo):base(marca,modelo)
        {
            Modelo = modelo;
            Marca = marca;
        }
        public Moto(string marca):base(marca)
        {
            Marca = marca;
        }

        //This is already 
        //public string Marca { get; set; }

        //public string Modelo { get; set; }

        public int NumeroRuedas { get; set; }

        public decimal Altura { get; set; }

        public void Arrancar()
        {
            Console.WriteLine("La moto arranca");
        }
        public void Acelerar()
        {
            Console.WriteLine("La moto acelera");
        }
        public void Apagar()
        {
            Console.WriteLine("La moto se apaga");
        }
    }
}
