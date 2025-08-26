using System.Collections;

namespace _37_Etut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methodlar
            /* Parametreli iş yapan Parametresiz iş yapan
             * Parametreli değer döndüren Parametresiz değer döndüren
             * Ref ve Out Parametreli
             * Params Parametreli
             * Overload (Aşırı Yükleme)
             * Optional (İsteğe Bağlı) Parametreli
             * Recursive (Özyinelemeli)
             * Class yapısı
             * Erişim Belirleyiciler (Access Modifiers)
            
            
            */
            #region Okul class ve method kullanımı
            //Okul okul = new Okul();
            ////okul.OgrenciEkle();
            //Console.WriteLine("Kaç öğrenci kayıt oldu");
            //int kayitSayisi = Convert.ToInt32(Console.ReadLine());
            //okul.OgrenciEkle(kayitSayisi);
            //int derslik = okul.OgrenciBildir();
            //int derslikSayisi = okul.DerslikArtir(derslik);
            //derslikSayisi+=derslik;
            //okul.DerslikEkle(derslikSayisi);
            //Console.WriteLine(okul.DerslikSayisi);
            //int ogretmenSayisi;
            //okul.OgretmenEkle(out ogretmenSayisi);
            //okul.OgretmenEkle2(ogretmenSayisi);
            //Console.WriteLine(okul.OgretmenSayisi);
            //int yonetici = 5;
            //okul.YoneticiEkle(ref yonetici);
            //okul.YonetimEkle(yonetici);

            #endregion
            #region Örnek 2 Optional ve Params
            Ogrenci ogrenci = new Ogrenci();
            //Console.WriteLine("Öğrenci Adı");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Öğrenci Soyadı");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("Öğrenci Bölümü");
            //string bolum = Console.ReadLine();
            //ogrenci.Kaydet(ad, soyad, bolum);
            //Console.WriteLine("Öğrenci Adı");
            //string ad2 = Console.ReadLine();
            //Console.WriteLine("Öğrenci Soyadı");
            //string soyad2 = Console.ReadLine();
            //Console.WriteLine("Öğrenci Bölümü");
            //string bolum2 = Console.ReadLine();
            //ogrenci.Kaydet(ad2, soyad2, bolum2);
            //Console.WriteLine("Öğrenci Adı");
            //string ad3 = Console.ReadLine();
            //Console.WriteLine("Öğrenci Soyadı");
            //string soyad3 = Console.ReadLine();
            //Console.WriteLine("Öğrenci Bölümü");
            //string bolum3 = Console.ReadLine();
            //ogrenci.Kaydet(ad3, soyad3, bolum3);

            //List<Ogrenci> ogrencis = new List<Ogrenci>()
            //{
            //    new Ogrenci(){Ad=ad,Soyad=soyad,Bolum=bolum},
            //    new Ogrenci(){Ad=ad2,Soyad=soyad2,Bolum=bolum2},
            //    new Ogrenci(){Ad=ad3,Soyad=soyad3,Bolum=bolum3},
            //};


            //ogrenci.Yazdir(ogrencis);

            //var sayi = 10;
            //var sayi2= "10";
            //ogrenci.OgrenciListele("Ahmet","Yılmaz","Yazılım","Ali","Demir","Makina","Mehmet","Kaya","Elektrik","Veli","Yılmaz","Elektronik");
            ogrenci.Kaydet2(2,0 );
            #endregion
            #endregion
        }
    }
}
