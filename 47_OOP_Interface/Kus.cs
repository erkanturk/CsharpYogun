using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_OOP_Interface
{
    internal class Kus : Canli, IYuruyenNesne, IYuzenNesne, IUcanNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Kuşum Uçarım");
        }

        public void Uc()
        {
            Console.WriteLine("Kuşum gök yüzünde süzülebilirim");
        }

        public void Yuru()
        {
            Console.WriteLine("Kuşum yürüyebilirim");
        }

        public void Yuz()
        {
            Console.WriteLine("kuşum yüzebilirim");
        }
    }
}
