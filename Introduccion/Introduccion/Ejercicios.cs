using System;
namespace Introduccion
{
    public class Ejercicios
    {
        /// <summary>
        /// Entrar por teclado 2 numeros y mostrar por pantalla  los pares
        /// </summary>
        public void Ejercicio1()
        {
            Console.Write("Por favor introduce el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Por favor introduce el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            
            for(int i = numero1; i <= numero2; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Numero par: "+ i);


            }
        }

        /// <summary>
        /// imprime los numeros perfectos entre 1 y n
        /// </summary>
        public void Ejercicio2()
        {
            Console.WriteLine("Por favor introduce un numero ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
                int sumaDivisores = 0;
                //Se comprueba si es un divisor
                for (int j=1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sumaDivisores += j;
                    }
                }

                if (i == sumaDivisores) {
                    Console.WriteLine($"El numero {i} es perfecto");
                }
            }
        }

        /// <summary>
        /// preguntar nombre y repetir hasta que introduzca lalo
        /// </summary>
        public void Ejercicio3()
        {
            string nombre;
            do
            {
                Console.Write("Por favor introduce un nombre:");
                nombre = Console.ReadLine();
            } while (nombre.ToLower() != "lalo".ToLower());

            Console.WriteLine("Bienvenido Lalo");
          
        }

    }
}
