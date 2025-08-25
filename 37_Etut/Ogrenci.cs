using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Etut
{
    internal class Ogrenci
    {
        int id;
        public string Ad;
        public string Soyad;
        public string Bolum;

        public void Kaydet(string ad, string soyad, string bolum, int id = 1)
        {
            Ad=ad;
            Soyad=soyad;
            Bolum=bolum;
            this.id=id;
        }
        public void Yazdir(List<Ogrenci> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"ID:{id} Ad:{item.Ad} Soyad:{item.Soyad} Bölüm:{item.Bolum}");
            }
        }
      

    }
}
