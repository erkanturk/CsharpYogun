using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Inheritance_2
{
    internal class C:B
    {
        public int c { get; set; }
        public C()
        {
            Console.WriteLine("C sınıfının ctor'u çalıştı");
        }
    }
}
