using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacionIntermedia
{
    public interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }

    }
    public class Car: IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Car()
        {

        }

        public Car(string marca,string modelo) {
            Marca = marca;
            Modelo = modelo;
        }
    }


    //TEntrada,TSalida
    //where new ()  para constructor vacio
    public class OperationResult<T,U>
        where T : Persona
        where U :Car
    {
        public bool Success => !MessageList.Any();
        public List<string> MessageList { get; set; }
        public T Contenido { get; set; }

        public OperationResult()
        {
            MessageList = new List<string>();
        }
        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }
        public void SetSuccessResponse(T obj)
        {
            Contenido = obj;
        }

    }

    public class Ejemplo
    {
        public T EjemploGenericMethod<T>(T x)
        {
            return x;
        }

        public void Metodo2()
        {

        }
    }


}
