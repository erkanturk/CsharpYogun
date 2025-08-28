using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_Partial_Class_3
{
    partial class Ogrenci
    {
        public int OgrenciNO;
        public string Bolum;
        public string DerslikNo;

        partial void Bilgi(string bolum);
        public void Bilgi2()
        {
            Console.WriteLine(OgrenciNO +" "+ Bolum +" "+DerslikNo+" "+Ad+" "+Soyad+" "+Tc);
            Bilgi(Bolum);
        }
    }
}
