using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_Partial_Class_2
{
    partial class Partial
    {
        partial void Test1()
        {
            Console.WriteLine("Test-1 Çalıştı");
        }
        partial void Test2()
        {
            Console.WriteLine("Test-2 çalıştı");
        }
        public void ErisilebilirMethod2()
        {
            Test1();
            Test2();
        }

    }
}
