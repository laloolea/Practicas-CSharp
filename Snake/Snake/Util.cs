using System;
namespace Snake
{
    public class Util
    {
        public static void DibujarPosicion(int x, int y,string caracter)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(caracter);
        }
    }
}
