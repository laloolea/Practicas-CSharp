using System;
namespace ProgramacionIntermedia
{
    public class SobreCarga
    {
        public int Suma(int item1,int item2)
        {
            return item1 + item2;
        }

        public int Suma(int item1,int item2, int item3)
        {
            return item1 + item2 + item3;
        }
        public string Suma(int item1,string item2)
        {
            return $"Suma entre {item1} y {item2}";
        }
        public string Suma(string item1,int item2)
        {
            return $"Suma entre {item1} y {item2}";
        }
    }
}
