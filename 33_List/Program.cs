namespace _33_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List
             * Generic typelar barındıran ve bu tiplere göre içinde elemanlar tutan bir koleksiyon yapısıdır
             * Çalışma prensibi FiFo dur 
             * Arraylist gibi her tipi içerisinde barındırmaz
             * Dataprotected bir yapıdır
             * hangi tipte olmasını istediğimizi belirtmemiz gerekmektedir
             * bir sınırı yoktur.
             * <> Genericyapılarda kullanılır. içerisine hangi tip olduğunu belirtmek zorundayız.
            
            */
            #region
            //List<string> liste = new List<string>();//boş liste
            //liste.Add("Öğrenci 1");
            //liste.Add("Öğrenci 2");
            //liste.Add("Öğrenci 3");
            //liste.Add("Öğrenci 4");
            //liste.Add("Öğrenci 5");
            //foreach (string item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> list = new List<int>() { 20, 30, 25, 35, 32, 45, 34, 64,24 };

            ////foreach (int item in list)
            ////{
            ////    if (item>30)
            ////    {
            ////        Console.WriteLine(item);
            ////    }
            ////}
            ////Where bir koşul yapısıdır  burada => lambda expression yas diğe bir değer oluşturup 
            ////kontrol sağlıyoruz eğer yaşlar 30 dan büyük se bize true olarak dönüyor ve bu yapıyı
            ////ToList ile 30 dan büyük olanları getiriyoruz.
            ////Linq Sorgu yöntemi
            //List<int> otuzdanBuyukYaslar=list.Where(yas=>yas>30).ToList();
            ////foreach (var item in otuzdanBuyukYaslar)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Find ile bir listenin içindeki değeri bulma işlemi yapabiliriz.
            //int bul = list.Find(y => y==24);
            //Console.WriteLine(bul);
            //double ortalama = list.Average();
            //Console.WriteLine(ortalama);//Yaş ortalaması
            //int toplam = list.Sum();
            //Console.WriteLine(toplam);//Listedeki yaşların Toplamı
            #endregion

            Kisi kisi = new Kisi();//Örneklem //Nesneleme //instance
            kisi.Ad="Erkan";
            kisi.Soyad="Türk";
            kisi.Yas=31;

            Kisi kisi2 = new Kisi();
            kisi2.Ad="Murat";
            kisi2.Soyad="Acar";
            kisi2.Yas=18;

            Console.WriteLine(kisi.Ad);
            Console.WriteLine(kisi.Soyad);
            Console.WriteLine(kisi2.Ad);
            Console.WriteLine(kisi2.Soyad);

            List<string> kisiAdlari = new List<string>();
            kisiAdlari.Add(kisi.Ad);
            kisiAdlari.Add(kisi2.Ad);
            kisiAdlari.Add(kisi.Soyad);
            kisiAdlari.Add(kisi2.Soyad);
            Console.WriteLine("*****************");
            foreach (var item in kisiAdlari)
            {
                Console.WriteLine(item);
            }

            List<Kisi> kisiler = new List<Kisi>();

            kisiler.Add(kisi);
            kisiler.Add(kisi2);
            Console.WriteLine("++++++++++++++++++");
            foreach (var item in kisiler)
            {
                Console.WriteLine(item.Ad+" "+item.Soyad+" "+item.Yas+" "+item.dogumTarihi);
            }

        }

    }
    class Kisi
    {
        //Property (özellik)
        public string Ad;
        public string Soyad;
        public int Yas;
        public DateTime dogumTarihi=DateTime.Now;
    }
}
