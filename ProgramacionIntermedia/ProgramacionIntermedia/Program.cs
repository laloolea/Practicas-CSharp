using ExplicacionInterface;
using System;
using System.Collections.Generic;

namespace ProgramacionIntermedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("Toyota", "prius", "2 ruedas");
            Moto moto1 = new Moto("kawaaki", "ninja", 1000);

            Console.WriteLine(coche1.Marca);
            moto1.Arrancar();
            coche1.Arrancar();
            moto1.Pitar();
            coche1.Pitar();

            Vehiculo vehiculo1 = (Vehiculo)moto1;

            IPieza triangulo = new TrianguloRectangulo(3, 4);
            IPieza cuadrado = new Cuadrado(4);


            interfaz1 ejemplo = new EjemploRepeticionMetodo();


            //ejemplo.MetodoRepetido();

            SobreCarga sobrecarga = new SobreCarga();

            sobrecarga.Suma(10, "10");
            sobrecarga.Suma(10, 10);
            sobrecarga.Suma(10, 10, 10);


            //Acutangulo acutangulo = new Acutangulo();

            //acutangulo.Area();
            //acutangulo.CalcularAreaTrianguloConHipotenusa(2, 3);
            //acutangulo.CalcularAreaEnBaseAngulos(1, 2, 3, 4);

            int numero = Calculadora.Suma(1, 2);
            Calculadora calculadora = new Calculadora();

            Console.WriteLine(calculadora.Media(new List<int>() { 1, 2, 3, 4 }));
        }   
    }
}
