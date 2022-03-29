using System;
namespace ConsoleApp1
{
    public class Vehiculo
    {
        public Vehiculo(decimal velocidadMaxima, decimal consumoPorKilometro)
        {
            VelocidadMaxima = velocidadMaxima;
            ConsumoPorKilometro = consumoPorKilometro;
        }
        //Public  - no tiene restricciones de acceso
        //Private - solo accesibles en la clase en la que se generan
        //Internal - solo son accesibles desde el propio proyecto
        //Protected - psolo accesible desde la clase que se genera y sus clases derivadas

        //Puedes tener clases con el mismo nombre solo si tienen diferente namespace

        //Comentarios de una linea
        /**
         * Comentarios de bloque mai friend
         */
        //

        public decimal VelocidadMaxima { get; set; }
        public decimal ConsumoPorKilometro { get; set; }


        /// <summary>
        /// calcula el consumo total de kilometros
        /// </summary>
        /// <param name="kilometrosTotales">Distancia recorrida en kilometros</param>
        /// <returns>Consumo total de litros de gasolina brow</returns>
        public decimal ConsumoTotal(decimal kilometrosTotales)
        {
            return kilometrosTotales * ConsumoPorKilometro;
        }
    }
}

