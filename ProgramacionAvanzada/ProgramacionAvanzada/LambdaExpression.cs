using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacionAvanzada
{
    public class EjemploLambda
    {
        Func<int, bool> mayorDeEdad = edad => edad >= 18;
        public int TestLambda()
        {
            List<Persona> personas = new List<Persona>()
            {
                new Persona(){Edad=14,Nombre="Javier"},
                 new Persona(){Edad=14,Nombre="Javier"},
                  new Persona(){Edad=14,Nombre="Javier"},
            };

            List<Persona> mayoresDeEdad = personas.Where(a =>a.Edad>=18).ToList();
            return mayoresDeEdad.Count();
        }
    }
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
       
    }
}
