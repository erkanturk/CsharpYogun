using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_OOP_Interface
{
    internal class Balik : Canli, IYuzenNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Denizde hareket ediyorum");
        }

        public void Yuz()
        {
            Console.WriteLine("Ben balığım yüzüyorum");
        }
    }
}
