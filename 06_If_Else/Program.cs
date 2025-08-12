namespace _06_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 6 adet sayı alalım ve bu  sayıların tek mi çift mi olduğunu kontrol ettirelim tek olan sayıları tek toplama 
            //Çift olan sayıları çift toplama ekleyelim
            #region Tek Çift Toplam
            //int tekToplam = 0;
            //int ciftToplam = 0;
            //Console.WriteLine("Lütfen 1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen 3. sayıyı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen 4. sayıyı giriniz");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen 5. sayıyı giriniz");
            //int sayi5 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen 6. sayıyı giriniz");
            //int sayi6 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1%2==0)
            //{
            //    ciftToplam+=sayi1;
            //}
            //else
            //{
            //    tekToplam+=sayi1;
            //}

            //if (sayi2%2==0)
            //{
            //    ciftToplam += sayi2;
            //}
            //else
            //{
            //    tekToplam += sayi2;
            //}
            //if (sayi3%2!=0)
            //{
            //    tekToplam+=sayi3;
            //}
            //else
            //{
            //    ciftToplam+=sayi3;
            //}
            //if (sayi4%2==1)
            //{
            //    tekToplam+=sayi4;
            //}
            //else
            //{
            //    ciftToplam+=sayi4;
            //}
            //if (sayi5%2==0)
            //{
            //    ciftToplam+=sayi5;
            //}
            //else
            //{
            //    tekToplam+=sayi5;
            //}
            //if (sayi6%2==0)
            //{
            //    ciftToplam+=sayi6;
            //}
            //else
            //{
            //    tekToplam+=sayi6;
            //}

            //Console.WriteLine("Tek Toplamlar: {0} Çift Toplamlar: {1}", tekToplam, ciftToplam);//index yazdırma biçimi
            //Console.WriteLine($"Tek Toplamlar: {tekToplam}  Çift Toplamlar: {ciftToplam}");//string interpolasyonu
            //Console.WriteLine("Tek Toplamlar: "+tekToplam+" Çift Toplamlar: "+ciftToplam);//string birleştirme

            //Console.WriteLine("Tek toplam: "+tekToplam);
            //Console.WriteLine("Çift toplam: "+ciftToplam);

            #endregion

            #region Örnek 2
            // Kullanıcıdan Aylık geliri istenecek ve Aylık geliri 40000 in üsünde ise %12 vergi kesilecek
            //40000 ve altıda ise %9 vergi kesimi yapılarak 
            //Kullanıcıya yeni geliri hesaplamalar sonucunda gösterilecek.
            //Console.WriteLine("Aylık Gelirizi giriniz.");
            //double gelir = Convert.ToDouble(Console.ReadLine());
            //if (gelir>40000)
            //{
            //    Console.WriteLine("Vergi kesilmiş gelir: "+gelir*0.88);
            //}
            //else
            //{
            //    Console.WriteLine("gelir: "+gelir*0.91);
            //}

            #endregion
            #region Örnek3
            //0-1000 harcama yapıldıysa 0.35 ile fiyatlandırılacak.
            //1001-2500 harcama 0.38 
            //2501-4000 harcama 0.41
            //4001-6000 harcama 0.42
            //6000 üstü için 1200 tl indirim yapılıp 0.43 üzerinden hesaplanacak.

            //Console.WriteLine("Harcama miktarı");
            //double harcama = Convert.ToDouble(Console.ReadLine());
            //if (harcama>=0 && harcama<1001)
            //{
            //    Console.WriteLine(harcama*0.35);

            //}
            //else if (harcama>=1001 && harcama<2501)
            //{
            //    Console.WriteLine(harcama*0.38);
            //}
            //else if (harcama>=2501 && harcama<4001)
            //{
            //    Console.WriteLine(harcama*0.41);
            //}
            //else if (harcama>=4001&& harcama<6001)
            //{
            //    Console.WriteLine(harcama*0.42);
            //}
            //else if (harcama>6000)
            //{
            //    Console.WriteLine((harcama*0.43)-1200);
            //}
            #endregion
            #region Örnek 4
            ////1-100 arasında sayıların 7 ye tam bölünenleri ekrana teker teker yazdıran yapıyı yazalım.
            //int sayi = 1;
            //basla:// goto kısmı bu alandaki git yapısına gelecektir bu yapı yukarıda : ile tanımlanır aşağıda ise ; ile 
            ////tanımlaması yapılır
            //if (sayi%7==0)
            //{
            //    Console.WriteLine(sayi);
            //}
            //sayi++;
            //if (sayi<=100)
            //{
            //    goto basla;
            //}
            #endregion
            #region Ödevler.
            /* ödev 1 if else
            Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.

             Eğer kulanıcının yaşı 45'in altındaysa;
             Çocuk sayısına bakılacak. Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺,
                                                       3'ten çok ise çocuk başına 2000₺ 
                                                             maaşa ekleme yapılacak.
             45'in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
             Son olarak ekrana : "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak. 
          */

            //Ödev 2 if else
            // Kullanıcıdan 3 adet sayı alınız ve bu sayıları şekil A görüldüğü gibi 
            //büyükten küçüğe sıralı bir şekilde ekrana yazdırınız
            //Şekil a: 15 13 5

            //Ödev switch-case ödev3
            /*
            kullanıcıdan alınan cinsiyet bilgisine göre
         ==> ERKEK ise
            yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, 
            yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise 
            maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
            6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> KADIN ise
             yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli 
            edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer
            5600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli 
            edilecek, 5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */
            #endregion

        }
    }
}
