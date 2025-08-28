using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_Partial_Class_3
{
    partial class Ogrenci
    {
        public string Tc;
        public string Ad;
        public string Soyad;

        partial void Bilgi(string bolum)
        {
            Console.WriteLine(bolum);
        }
    }
}
