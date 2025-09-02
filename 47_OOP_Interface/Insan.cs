using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_OOP_Interface
{
    internal class Insan : Canli, IYuzenNesne, IYuruyenNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Insanım Koşuyorum");
        }

        public void Yuru()
        {
            Console.WriteLine("Insanım Yürüyorum");
        }

        public void Yuz()
        {
            Console.WriteLine("Insanım Yüzüyorum");
        }
    }
}
