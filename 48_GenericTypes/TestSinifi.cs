using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_GenericTypes
{
    internal class TestSinifi<T>
    {
        public int NonGenerinField;
        public T GenericField;//GenericField'ın tipi tasarım zamanında belli değildir. Nesne üretildikten sonra belirtilecektir.
    }
}
