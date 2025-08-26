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

        public void OgrenciListele(params string[] ogrenciler)
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            for (int i = 0; i<ogrenciler.Length; i+=3)
            {
                if (i+2<ogrenciler.Length)
                {
                    Ogrenci ogrenci = new Ogrenci()
                    {
                        Ad = ogrenciler[i],
                        Soyad = ogrenciler[i + 1],
                        Bolum = ogrenciler[i + 2]
                    };
                    ogrencis.Add(ogrenci);
                }
                else
                {
                    Console.WriteLine("Eksik bilgi var");
                }

            }
            foreach (var item in ogrencis)
            {
                Console.WriteLine($"Ad:{item.Ad} Soyad:{item.Soyad} Bölüm:{item.Bolum}");
            }


        }
        public void Kaydet2(int sayi,int sayi2)
        {
            Ogrenci ogrenci = new Ogrenci();
            List<Ogrenci> ogrencis = new List<Ogrenci>();   
            Console.WriteLine("Öğrenci adı");
            ogrenci.Ad =Console.ReadLine();
            Console.WriteLine("Öğrenci Soyadı");
            ogrenci.Soyad=Console.ReadLine();
            Console.WriteLine("Bölüm");
            ogrenci.Bolum =Console.ReadLine();

            ogrencis.Add(ogrenci);
            if (sayi>sayi2)
            {
                Kaydet2(sayi-1, sayi2);// Recursive yapıda bu yapı gelen sayı değerini düşürerek bir işlemin tamamını 
                //yapmak yerine parçalı bir şekilde yapmasını sağlar.
                //sayı değeri azaldığı için if yapısı false olarak dönecek ve sonlanacaktır sonrasında ise
                //yapılan her bir sayı işlemi if içerisine gelip 1 2 3 diye kayıtları yazdıracaktır.

            }
            foreach (var item in ogrencis)
            {
                Console.WriteLine($"Ad:{item.Ad} Soyad:{item.Soyad} Bölüm:{item.Bolum}");
            }

        }

    }
}
