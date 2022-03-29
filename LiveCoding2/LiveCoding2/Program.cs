using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace LiveCoding2
{
    class Program
    {
        static string path = @"/Users/eduardogonzalez/Documents/Projects/livecoding/Log-LiveCoding.log";
        static void Main(string[] args)
        {
            string fechaString;
            do
            {
                Console.WriteLine("Introduce una fecha en formato yyyyMMdd");
                fechaString = Console.ReadLine();
                DateTime fecha = DateTime.ParseExact(fechaString, "yyyyMMdd", new CultureInfo("es-ES"));

                string texto = $"La fecha es {fecha.DayOfWeek}, {fecha.Day}, {fecha.ToString("MMMM")} de {fecha.Year}";
                Console.WriteLine(texto);
                EscribirLog(texto);
            } while (fechaString != "0");

            Console.ReadKey();
        }

        public static void EscribirLog(string mensaje)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) { }

            }
            File.AppendAllLines(path, new List<string> { mensaje+"\n" });

        }
    }
}
