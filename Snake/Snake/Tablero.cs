using System;
namespace Snake
{
    public class Tablero
    {
        public readonly int Altura;
        public readonly int Anchura;
        public bool ContieneCaramelo;

        public Tablero(int altura,int anchura)
        {
            Altura = altura;
            Anchura = anchura;
            ContieneCaramelo = false;
        }

        public void DibujarTablero()
        {
            for (int i = 0; i <= Altura; i++)
            {
                //Linea de arriba

                Util.DibujarPosicion(i, Altura, "*");
           
                //Linea de abajo
                Util.DibujarPosicion(Anchura, i, "*");


                //Linea izquierda
                Util.DibujarPosicion(0, i, "*");


                //Linea de abajo
                Util.DibujarPosicion(i, 0, "*");

            }


        }

    }
}
