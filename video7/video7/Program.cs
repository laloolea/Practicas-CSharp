using System;
using System.Text;
namespace video7
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ejemplo = "Lalo Olea";

            //char[] testArrayString = { 'L', 'A', 'L', 'O' };

            //string testJuntoArray = new string(testArrayString);


            //string concatenacionEjemplo = ejemplo + " como estas";

            //string interpolationString = $"esto es un ejemplo {ejemplo}";

            //Console.WriteLine(string.Format("La temperatura es  {0}  ",100));

            //string myString ="Tengo un vaso 1leno de";

            //Console.WriteLine(myString.ToUpper());
            //Console.WriteLine(myString.ToLower());
            //Console.WriteLine(myString.Equals("Tengo un vaso lleno de"));
            //Console.WriteLine(myString.IndexOf("o"));
            //Console.WriteLine(myString + " zumo de naranja");
            //Console.WriteLine(myString.Contains("vaso"));

            //string almacena en memoria y cuando lo cambias el valor en lugar de cambiarlo crea otro y se limpiara con el garbage collector
            //string builder usa las mismas posiciones de memoria

            StringBuilder sbEjemplo = new StringBuilder("hola");

            sbEjemplo.Append(" eduardo como estas");
            Console.WriteLine(sbEjemplo);
        }
    }
}
 