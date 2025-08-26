using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Class_Constructor
{
    internal class Ogrenci
    {
        public int OgrenciNo;
        public string AdSoyad;

        public void Bilgi()
        {
            Console.WriteLine($"Bilgi Ad Soyad:{AdSoyad} Öğrenci No:{OgrenciNo}");
        }
        public Ogrenci()
        {
            Console.WriteLine("Ctor Çalıştı");
        }
        
        public Ogrenci(string AdSoyad,int OgrenciNo)
        {
            this.AdSoyad=AdSoyad;//this anahtar kelimesi ile sınıfın üyesine erişiyoruz
            this.OgrenciNo=OgrenciNo;
            Console.WriteLine($" Ctor Ad Soyad:{AdSoyad} Öğrenci No:{OgrenciNo}");

        }
    }
}
