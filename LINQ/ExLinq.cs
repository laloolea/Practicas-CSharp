using System;
using System.Collections.Generic;

namespace LINQ
{
    public static class ExLinq
    {
        public static IEnumerable<T> Filtro<T>(this IEnumerable<T> source, Func<T, bool> predicado)
        {
            List<T> result = new List<T>();

            foreach(var item in source)
            {
                if (predicado(item))
                {
                    yield return item;
                }
            }

        }
    }
}
