using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Polymorphism_2
{
    internal class Swift:HesapIslemleri
    {
        public override void ParaGonder(int tutar)
        {
            Console.WriteLine($"{tutar} tutarında Swift işlemi yapıldı");
        }
    }
}
