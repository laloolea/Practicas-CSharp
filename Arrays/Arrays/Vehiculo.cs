﻿using System;
namespace Dia2
{
    public class Vehiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {

            Marca = marca;
            Modelo = modelo;
        }
        public Vehiculo(string marca)
        {
            Marca = marca;
        }
    }
}
