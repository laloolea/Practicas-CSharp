using System;
namespace ProgramacionIntermedia
{
    public class ChecarNull
    {

        public void Execute()
        {
            // C#6
            //int i = 1;
            //if (i == null)
            //{

            //}

            //C#7
            // un poco confuso
            //string i = null;
            //if (i is null)
            //{
            //    return "this is null";
            //}
            //if (!(i is null))
            //{

            //}
            //if (i is object)
            //{

            //}

            //C#8 .net standard 2.1 .Net core 3.1
            //sring i = null;
            //if(i is { }) //lo mismo que if i is object
            //{

            //}

            //Con C#9
            //string i = null;
            //if(i is not null)
            //{

            //}
        }
        public ChecarNull()
        {
        }
    }
}

