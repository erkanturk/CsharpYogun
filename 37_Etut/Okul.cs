using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Etut
{
    internal class Okul
    { //Class yapısı ve parametreli parametresiz method overload yapısı
        public int DerslikSayisi;
        public int OgrenciSayisi;
        public int OgretmenSayisi;
        public int YonetimSayisi;

        public void OgrenciEkle()
        {
            OgrenciSayisi+=50;//Bu değeri karşılayacak bir parametre olmadığı için bu yapı sabit olarak değer verir.
        }
        public void OgrenciEkle(int sayi)
        {
            OgrenciSayisi+=sayi;
        }
        public void OgrenciCikar()
        {
            OgrenciSayisi-=20;
        }
        public void OgrenciCikar(int sayi)
        {
            OgrenciSayisi-=sayi;
        }

        public int OgrenciBildir()
        {
            int toplam = OgrenciSayisi;
            return toplam;
        }
        public void DerslikEkle(int sayi)
        {
            DerslikSayisi+=sayi;
        }
        public int DerslikArtir(int sayi)
        {
            return sayi;
        }
        public void OgretmenEkle(out int sayi)//Out ile bir işlem sonucunda null olan değeri dışarıya bir veri olarak çıkardık
       //örneğimizde belirli olmayan bir öğretmen sayısı var null olan değeri
       //biz derslik ve öğrenci sayısına göre bir işlem yaparak öğretmen sayısını belirledik
        {
            sayi=DerslikSayisi/OgrenciSayisi;

        }
        public void OgretmenEkle2(int sayi)
        {
            OgretmenSayisi=sayi;

        }
        public void YoneticiEkle(ref int sayi)
        {
            YonetimSayisi=sayi;
            Console.WriteLine(YonetimSayisi);
            sayi+=5;//ref ile gelen değeri method içinde değiştirebiliriz.

           
        }
        public void YonetimEkle(int sayi)
        {
            YonetimSayisi=sayi;
            Console.WriteLine("Temizlik ve diğer personeller eklendi "+YonetimSayisi);
        }

    }

}
