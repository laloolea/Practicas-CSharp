using System;
namespace ProgramacionIntermedia
{
    public class Excepciones:Exception
    {
        public Excepciones(string mensaje) :base(mensaje)
        {
           //Alertas.EnviarEmailAlerta("intento de jakeoo,message");
        }
    }
}
