using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_Partial_Class
{
    partial class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Personel()
        {

        }

        public void BilgiVer()
        {
            Console.WriteLine("Test Personel");
        }
        public void Deneme()
        {
            Console.WriteLine("Deneme");
        }
    }
}
