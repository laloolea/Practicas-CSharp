 using System;
namespace ProgramacionIntermedia
{
    public class Persona
    {
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }

    
}
