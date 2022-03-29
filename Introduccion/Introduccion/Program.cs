using System;

namespace Introduccion
{
    class Program
    {

        /// <summary>
        /// Hacer un menu para elegir que ejercici hacer
        /// 
        /// </summary>
  
        static void Main(string[] args)
        {
            //Console.Write("Escribe un nombre: ");
            //string nombre = Console.ReadLine();


            ////mismo si solo es una sentencia no se necesitan {} pero se pueden poner
            //if(nombre == "Lalo")
            //{
            //    Console.WriteLine("Hola lalo");
            //}
            //else if (nombre == "test")
            //{
            //    Console.WriteLine("test");
            //}else if (nombre == "test2")
            //{
            //    Console.WriteLine("Buenos dias");
            //}
            //else
            //{
            //    Console.WriteLine("Hola desconocido");
            //}

            ////Operador ternario
            ////         Si nombre es igual a lalo es 26, else  10
            //int edad = (nombre == "Lalo" ? 26 : 10);


            //switch (nombre)
            //{
            //    case "Lalo":
            //        Console.WriteLine("Hola lalo");
            //        break;
            //    case "test":
            //        Console.WriteLine("test");
            //        break;
            //    case "test2":
            //        Console.WriteLine("Buenos dias");
            //        break;
            //    default:
            //        Console.WriteLine("Hola desconocido");
            //        br`eak;

            //for(int i = 0; i <= 10; i++)
            //{  
            //        Console.WriteLine("Iteracion de for: " + i);
            //}

            //int iterador = 0;
            //while (iterador <= 10)
            //{
            //    Console.WriteLine("Iteracion de while: " + iterador);
            //    iterador++;

            //}

            //do
            //{
            //    //Whatever you want
            //} while (iterador <= 100);

            Ejercicios ej = new Ejercicios();
            int opcionMenu = 0;
            do
            {
                opcionMenu = Menu();

                switch (opcionMenu)
                {
                    case 1:
                        ej.Ejercicio1();
                        break;

                    case 2:
                        ej.Ejercicio2();
                        break;
                    case 3:
                        ej.Ejercicio3();
                        break;

                    case 0:
                        break;

                         
                }

            } while (opcionMenu != 0);
            Console.WriteLine("Pulsa alguna tecla para salir");
        }






        static int Menu()
        {
            Console.WriteLine("Introduce una opcion del menu: ");
            Console.WriteLine("1.-Numeros Pares");
            Console.WriteLine("2.- Numeros perfectos");
            Console.WriteLine("3.- Introducir nombre ");
            Console.WriteLine("0.- Salir de la aplicacion ");

            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
