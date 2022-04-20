using System;

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ProgramacionAvanzada
{
    public class Ejemplo
    {
        public IList<long> Items { get; set; }
        public IList<long> ItemsList2 { get; set; }

        public Ejemplo()
        {
            Items = Enumerable.Range(1, 1000000).Select(a => Convert.ToInt64(a)).ToList();
            ItemsList2 = Enumerable.Range(1, 1000000 - 1).Select(a => Convert.ToInt64(a)).ToList();
            ItemsList2.Add(1);
        }
        public bool EqualsGeneric(IList<long> x, IList<long> y)
        {
            if (ReferenceEquals(x, y))
                return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;
            if (x.Count != y.Count)
                return false;
            for (var i = 0; i < x.Count; i++)
            {
                if (x[i] == null)
                {
                    if (y[i] != null)
                        return false;
                }
                else if (!x[i].Equals(y[i]))
                {
                    return false;
                }
            }
            return true;
        }
        [Benchmark]
        public void BenchmarkGenericEquals()
        {
            _=EqualsGeneric(Items, ItemsList2);
        }
        [Benchmark]
        public void BenchMarkLongEquals()
        {
            _ = EqualsLong(Items, ItemsList2);

        }

        public bool EqualsLong(IList<long> x, IList<long> y)
        {
            if (ReferenceEquals(x, y))
                return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;
            if (x.Count != y.Count)
                return false;
            for (var i = 0; i < x.Count; i++)
            {
                if (!x[i].Equals(y[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
