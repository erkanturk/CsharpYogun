using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Class_Constructor
{
    internal class Kisi
    {
        public string Ad;
        public string Soyad;
        public int Yas;

        //Solid Prensipleri Dependency Inversion Principle
        public Kisi()
        {
            
        }
        public Kisi(string ad, string soyad,int yas)
        {
            Ad= ad;
            Yas= yas;
            Soyad=soyad;
            Console.WriteLine($"Ctor Ad:{Ad} Soyad:{Soyad} Yaş:{Yas}");
        }
        public void Yazdir()
        {
            Console.WriteLine($"Ad:{Ad} Soyad:{Soyad} Yaş:{Yas}");
        }
    }
}
