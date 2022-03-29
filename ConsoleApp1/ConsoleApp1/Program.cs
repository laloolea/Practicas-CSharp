using System;

using ConsoleApp1.espacio2;
namespace ConsoleApp1
{
    class Program
    {
        public const int NumeroMeses = 12;
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo eduardo "+NumeroMeses);
            //Console.ReadKey();

            //podemos accesar porque vehiculo esta dentro del mismo namespace
            var ejemplo = new Vehiculo(200,10);
            Console.WriteLine("Consumo total del vehiculo: " + ejemplo.ConsumoTotal(100));

            //variable valor que compilador agarra de forma dinamica y puede ir cambiando a lo largo del programa
            //tipos de variables primitivos (compilador puede asignar el valor directamente): byte, short, int, long, float, double, decimal, char, bool

            
            int myInt = 4;
            double myDouble = 3.15;
            //The main difference is Floats and Doubles are binary floating point types and a Decimal will store the value as a floating decimal point type. So Decimals have much higher precision and are usually used within monetary (financial) applications that require a high degree of accuracy
            //defecto el compilador los numeros que llevan decimales son tomados como flotantes 
            decimal myDecimal = 2.2m ; // or Convert.ToDecimal(2.2);

            //char mychar;
            // tipos no primitivos clases, structs, enum, array, string, datetime.

            EmptyClass emptyClass = new EmptyClass();

            DiasSemana diasSemana = DiasSemana.lunes;

            int[] myArray = new int[5];

            string myString = "Hola como estas";
            DateTime myDateTime = new DateTime(2019, 03, 01);

            // var es para cualquier tipo  no especificas pero dependiendo de al asignacion  es recomendado usar el tipo tal vez solo si solo la usaras en la siguiente linea pero no es muy usado
            //Write escribes sobre la misma linea writeline escribes debajo en una linea aparte
            //Console.Write("Por favor introduce un nombre: ");
            //string nombre = Console.ReadLine();

            ////Readline reads a whole line
            //Console.Write("Por favor introduce tu edad: ");
            //int edad = int.Parse(Console.ReadLine());

            //Console.Write("Por favor introduce un caracter: ");
            ////read lee solo un caracter  
            //int myCaracter = Console.Read(); 

            //Console.WriteLine("has introducido: " + nombre);

            //Console.WriteLine("El doble de tu edad es: " + edad*2);


            //Se cambia el color del texto apartir de ahi
            //Console.ForegroundColor = ConsoleColor.Red;
            //{0,5} 0 es la posicion del valor que mandaras, y 5 el tamaño que quieres mostrar 
            //Console.WriteLine("{0,5}, {1,5}",123,456);
            //Console.WriteLine("El valor ascii introducido es: " + myCaracter);


            Console.Write("Por favor introduce tu edad: ");
            string myAge = Console.ReadLine();
          
            Console.Write("Por favor introduce la edad de tu padre: ");
            string dadAge = Console.ReadLine();
                     
            Console.WriteLine("La diferencia de edad de tu papa y tu es: " + (int.Parse(dadAge) - int.Parse(myAge)));
            Console.WriteLine("La diferencia de edad de tu papa y tu es: {0} años" , ((int.Parse(dadAge) - int.Parse(myAge))));
        }
    }
}
