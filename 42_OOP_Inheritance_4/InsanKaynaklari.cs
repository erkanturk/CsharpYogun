using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Inheritance_4
{
    internal class InsanKaynaklari:Personel
    {
        public int PersonelSayisi { get; set; }

        public new void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Personel Sayisi");
            this.PersonelSayisi=Convert.ToInt32(Console.ReadLine());

        }
        public static void Listele(List<InsanKaynaklari> liste)
        {
            foreach (InsanKaynaklari item in liste)
            {
                Console.WriteLine($"{item.Id}-{item.Ad}-{item.Soyad}-{item.TcNo}-{item.SskGirisTarihi}-{item.PersonelSayisi}");
            }
        }
        public static void Sil(List<InsanKaynaklari> liste)
        {
            Listele(liste);
            Console.WriteLine("Silinecek Personel Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            //Linq ile ileri seviye sorgulama yöntemi
            //Select * from InsanKaynaklari where Id=id
            InsanKaynaklari silinecekPersonel = liste.FirstOrDefault(i => i.Id==id);
            //Kullanıcının girdiği id değeri benim personel yapımda var mı var ise ilkini veya 
            //varsayılan değeri getir

            if (silinecekPersonel==null)
            {
                Console.WriteLine("Girilen Personel bulunamadı");
            }
            else
            {
                bool sonuc = liste.Remove(silinecekPersonel);
                if (sonuc)
                {
                    Console.WriteLine("Personel Silindi");
                }
                else
                {
                    Console.WriteLine("Personel Silinemedi");
                }

            }
        }
        public static void Guncelle(List<InsanKaynaklari> liste)
        {
            Listele(liste);
            Console.WriteLine("Guncellenecek Personel Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            //Linq ile ileri seviye sorgulama yöntemi
            //Select * from InsanKaynaklari where Id=id
            InsanKaynaklari guncellenecekNo = liste.FirstOrDefault(i => i.Id==id);
            //Kullanıcının girdiği id değeri benim personel yapımda var mı var ise ilkini veya 
            //varsayılan değeri getir

            if (guncellenecekNo==null)
            {
                Console.WriteLine("Girilen Personel bulunamadı");
            }
            else
            {
              guncellenecekNo.Kaydet();

            }
        }
    }
}
