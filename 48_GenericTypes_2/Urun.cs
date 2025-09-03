using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_GenericTypes_2
{
    internal class Urun<T>
    {
        public T Value { get; set; }
        public T Value2 { get; set; }
        public Urun(T value, T value2)
        {
            Value = value;
            Value2 = value2;
        }
    }
    class Urun<T, K>
    {
        public T Value { get; set; }
        public K Value2 { get; set; }
        public Urun(T value,K value2)
        {
            Value2 = value2;
            Value=value;
        }
    }
}
