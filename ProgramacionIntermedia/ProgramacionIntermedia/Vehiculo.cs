using System;
namespace ProgramacionIntermedia
{
    public /*sealed*/ class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set;  }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public virtual void Pitar()
        {
            Console.WriteLine("El vehiculo pito");

        }
        public  void Arrancar() {
            Console.WriteLine("Arrancar vehiculo");
        }
    }
}
