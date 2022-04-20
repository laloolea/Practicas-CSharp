using ExplicacionInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgramacionIntermedia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coche coche1 = new Coche("Toyota", "prius", "2 ruedas");
            //Moto moto1 = new Moto("kawaaki", "ninja", 1000);

            //Console.WriteLine(coche1.Marca);
            //moto1.Arrancar();
            //coche1.Arrancar();
            //moto1.Pitar();
            //coche1.Pitar();

            //Vehiculo vehiculo1 = (Vehiculo)moto1;

            //IPieza triangulo = new TrianguloRectangulo(3, 4);
            //IPieza cuadrado = new Cuadrado(4);


            //interfaz1 ejemplo = new EjemploRepeticionMetodo();


            ////ejemplo.MetodoRepetido();

            //SobreCarga sobrecarga = new SobreCarga();

            //sobrecarga.Suma(10, "10");
            //sobrecarga.Suma(10, 10);
            //sobrecarga.Suma(10, 10, 10);


            ////Acutangulo acutangulo = new Acutangulo();

            ////acutangulo.Area();
            ////acutangulo.CalcularAreaTrianguloConHipotenusa(2, 3);
            ////acutangulo.CalcularAreaEnBaseAngulos(1, 2, 3, 4);

            //int numero = Calculadora.Suma(1, 2);
            //Calculadora calculadora = new Calculadora();

            //Console.WriteLine(calculadora.Media(new List<int>() { 1, 2, 3, 4 }));

            //Console.WriteLine("\n\nMetodo extendido" + " hola".PrimeraLetraMayuscula());

            //var equipo = new { Nombre = "America", Ligas = 1 };
            //Test(equipo);

            //List<Persona> personas = new List<Persona>();
            //personas.Add(new Persona() { Nombre = "Raul", Apellido = "Albiol", Edad = 33 });
            //personas.Add(new Persona() { Nombre = "Iago", Apellido = "aspas", Edad = 28 });
            //var resultado = personas.Where(a => a.Edad == 28)
            //    .Select(a=> new { Nombre = a.Nombre, edad = a.Edad });


            //Entero nullos
            //TipoNullable hola = new TipoNullable(null);
            //int enteroNormal = 34;

            //if (hola.EnteroNulo.HasValue)
            //{
            //    enteroNormal = hola.EnteroNulo.Value;
            //}

            ////operador terneario
            //int mayoriaEdad = 18;
            //int edadActual = 21;
            //string result;
            ////if (mayoriaEdad <= edadActual)
            ////{
            ////    result = "El usuario es mayor de edad";
            ////}
            ////else
            ////{
            ////    result = "El usuario es menor de edad";
            ////}
            //int votar = 21, conducir = 25;
            //result = mayoriaEdad <= edadActual ? "El usuario es mayor de edad" : "El usuario es menor de edad";


            //if(conducir <= edadActual)
            //{
            //    result = "Puede conducir y votar";
            //}
            //else if (votar <= edadActual)
            //{

            //     result = "puede votar ";



            //} else if(mayoriaEdad <= edadActual)
            //{

            //    result = "es mayor de edad";


            //}
            //else
            //{
            //    result = "No puede hacer nada";
            //}
            //result = conducir <= edadActual ? "Puede conducir y votar" : votar <= edadActual ?
            //     "puede votar" : mayoriaEdad <= edadActual ?
            //    "Es mayor de edad" : "No puede hacer nada";
            //Console.WriteLine(result);
            //dynamic variableDinamica = 1;
            //variableDinamica = "hola";

            //dynamic valor = new Persona() { Nombre = "Raul", Apellido = "Albiol", Edad = 33 };

            //Console.WriteLine(valor.Nombre+"\n\n");
            //Console.WriteLine(valor.GetType().ToString());
            //var resultado = new OperationResult<Persona,Car>();
            //Persona p = resultado.Contenido;

            //var resultadoCar = new OperationResult<Car,Persona>();
            //Car c = resultadoCar.Contenido;
            //Car coche = new Car("Opel","Vectra");
            //resultadoCar.SetSuccessResponse(c);

            //Ejemplo ej = new Ejemplo();
            //ej.Metodo2();
            ////Desde c# cuando se llama un metodo no es necesario poner el indicador deltipo<string>
            //_ = ej.EjemploGenericMethod<string>("Hola");
            //var stringCollection = new SampleCollection<string>();
            //stringCollection[0] = "Hello, World";
            //Console.WriteLine(stringCollection[0]);
            //string frase = "hablar";

            //bool isMatch = Regex.IsMatch(frase, @"\A"); //boolean if it match

            //Match resultadoMatch = Regex.Match(frase, @""); // returns object about th ematch

            // isMatch = Regex.IsMatch(frase, @"(^[h])([r]$)");
            //string[] arrayfrases = Regex.Split(frase, ",");

            //Console.WriteLine(isMatch);
            //var regex = new Regex("patron");
            //Regex.Match(frase, "patron"); // Metodo más utilizado


            //Tuple<string, string, int> coche = new Tuple<string,string,int>("audi","a3",2008);
            //var coche2 = Tuple.Create("opel", "astra", 2005);

            //Console.WriteLine($"{coche.Item1}, {coche.Item2}");

            ////Value tuple representacion por valor de la tupla
            ////ImprimirCoche(coche);

            //(string marca,string modelo,int year) moto1 = ("Derbi", "variant", 1980);

            //ImprimirCoche(moto1) ;
            //(string marcaMoto2, string modeloMoto2, int yearMoto2) = GetMotoDatabase();
            //Console.WriteLine(marcaMoto2
        }


        
        static void TestDynamic(dynamic valor)
        {
            Console.WriteLine(valor);

        }


        public static void Test(dynamic equipo)
        {
            Console.WriteLine(equipo.Nombre);
            if (1 != 1)
            {
                throw new Excepciones("Ejemplo ");
            }
        }

        public (string, string, int) GetMotoDatabase()
        {
            return ("Honda", "CBR", 2005);
        }
        public void ImprimirCoche((string, string, int) coche)
        {
            Console.WriteLine($"El primer coche es un {coche.Item1} {coche.Item2} del año {coche.Item3}");
        }

        public void ImprimirCoche(Tuple<string, string, int> coche)
        {
            Console.WriteLine($"El primer coche es un {coche.Item1} {coche.Item2} del año {coche.Item3}");
        }
        public Tuple<string, string, int> CalcularCoche3()
        {
            return Tuple.Create("Ford", "Fiesta", 2009);
        }

    }

}
