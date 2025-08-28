using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_Partial_Class
{
    partial class Personel
    {
        public int Yas { get; set; }

        public Personel(string name)
        {

        }
        public void BilgiVer(int id)
        {
            Console.WriteLine("Personel 1 sınıfı");
        }
        public void Test()
        {
            Console.WriteLine("TEst Personel1");
        }
    }
}
