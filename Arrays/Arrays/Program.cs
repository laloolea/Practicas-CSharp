using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dia2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays------------------------------
            //int[] arrayEnteros = new int[5];
            //arrayEnteros[0] = 25;
            //arrayEnteros[1] = 1;
            //arrayEnteros[2] = 22;
            //arrayEnteros[3] = 11;
            //arrayEnteros[4] = 20;

            //Listas------------------------------
            //List<string> ejemplolistaciudades = new List<string>();
            //ejemplolistaciudades.Add("Huesca");
            //ejemplolistaciudades.Add("Zaragoza");
            //ejemplolistaciudades.Add("Teruel");
            //ejemplolistaciudades.Add("Cáceres");
            //ejemplolistaciudades.Add("Badajoz");
            //IEnumerable<string> ciudadesEncontradas =ejemplolistaciudades.Where(x => x.ToLower().Contains("e"));
            //foreach (var ciudad in ciudadesEncontradas)
            //    Console.WriteLine(ciudad);

            //Datetimes------------------------------
            //DateTime simulacionFechaSistema = new DateTime(2019, 01, 10, 17, 30, 12);
            //Console.WriteLine($"El tiempo de mi sistema es :{ simulacionFechaSistema.ToString("yyy-System.IO.FileNotFoMM-dddd:mm:ss.ms")}");
            //Console.WriteLine($"Revision de mi sistema es : { simulacionFechaSistema.ToString("MMSystem.IO.FileMM")}");

            //STREAM READERRR ----------------
            //@ escapar contrabarra
            //using (StreamReader reader = new StreamReader(@"/Users/eduardogonzalez/Documents/Projects/ejemplo1.txt"))
            //{
            //    string text;
            //    while ((text = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(text);
            //    }
            //}

            //STREAM WRITER
            //string[] ciudades = new string[] { "Madrid", "Hermosillo", "Obregon", "Barcelona","Mexico" };
            //string ciudad5 = "Nogales";
            ////Sobrescribe si quieres anadir algo nuevo tienes que copiar todoo el fichero antes y luego agregar el nuevo 
            //using (StreamWriter writer = new StreamWriter(@"/Users/eduardogonzalez/Documents/Projects/ciudades.txt"))
            //{
            //    foreach(string ciudad in ciudades)
            //    {
            //        writer.WriteLine(ciudad);
            //    }
            //}


            ////.ReadAllText;
            ////ReadAllLines; array de strings
            //string fileReader = File.ReadAllText(@"/Users/eduardogonzalez/Documents/Projects/ciudades.txt");
            //Console.WriteLine(fileReader);

            ////WriteAllText or WriteAllLines
            ////Tambien remplaza, pero se puede anadir al final 
            ////File.WriteAllLines(@"/Users/eduardogonzalez/Documents/Projects/ejemplo1.txt", ciudades);
            //File.WriteAllText(@"/Users/eduardogonzalez/Documents/Projects/ejemplo1.txt", "Hola como tas\n ");

            ////anadir al final es AppendText or AppendAllLines
            //File.AppendAllLines(@"/Users/eduardogonzalez/Documents/Projects/ejemplo1.txt", ciudades);

            //Moto moto = new Moto("Kawasaki","FX");



            //Console.WriteLine(moto.Marca);




            //EXCEPCIONES--------------------------------
            //Console.Write("Por favor introduce un por el que vamos a dividir el numero 25: ");

            //var numeroEntero = Console.ReadLine();
            //try
            //{

            //    int numeroPorDividir = Convert.ToInt32(numeroEntero);

            //    Console.WriteLine($"El resultado de la division es: {25 / numeroPorDividir}");
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("no puedes dividir por 0");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Ha habido un error en la ejecucion del programa: { e.Message.ToString()}");
            //}

            int valorActual = 10;
            //Por valor
            Actualizar(out valorActual);
            Console.WriteLine($"el valor es: {valorActual}");

            //Por referencia, si se modifica el valor dentro metodo se modifica el original
            //ese parametro cambiara de valor dentro del metodo

            //palabra reservada out para inicializar el valor de una variable dentro de un metodo, variable instanciada previamente

            //palabra reservada in cuando no queremos que se quiera modificar dentro del metodo, pero se puede usar readonly

            //. This readonly keyword shows that you can assign the variable only when you declare a variable or in a constructor of the same class in which it is declared.

            ObjEjemplo ejemploValor = new ObjEjemplo(10);

            ActualizarObj(ejemploValor);
            Console.WriteLine($"el valor es {ejemploValor.Entero}");
        }

        public static void Actualizar( int valor)
        {
            valor += 5;
            Console.WriteLine($"el valor es: { valor}");
        }
        public static void Actualizar(out int valor)
        {
            valor = 5;
            Console.WriteLine($"el valor es: { valor}");
        }

        public static void ActualizarObj(ObjEjemplo obj)
        {
            obj.Entero = 25;
        }


       

       


        public static int Suma (int[] arrayEnteros)
        {

            int result = 0;
            for(int i = 0; i < arrayEnteros.Length; i++)
            {
                result += arrayEnteros[i];
            }
            return result;
        }
        public static decimal Media(int[] arrayEnteros)
        {

            int sum = Suma(arrayEnteros);

            decimal result = (decimal)sum / arrayEnteros.Length;

            return result;
        }
    }
    public class ObjEjemplo
    {
        public int Entero { get; set; }
        public ObjEjemplo(int entero)
        {
            Entero = entero;
        }
    }
}
