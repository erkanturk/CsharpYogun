namespace _12_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödevler.




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
            #region Ödev1 Çözüm
            /* ödev 1 if else
          Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.

           Eğer kulanıcının yaşı 45'in altındaysa;
           Çocuk sayısına bakılacak. Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺,
                                                     3'ten çok ise çocuk başına 2000₺ 
                                                           maaşa ekleme yapılacak.
           45'in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
           Son olarak ekrana : "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak. 
        */
            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Yaşınız:");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Çocuk sayısı:");
            //int cocukSayisi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Maaş:");
            //double maas = Convert.ToDouble(Console.ReadLine());

            //if (yas>0 && yas<45)
            //{
            //    if (cocukSayisi>=3)
            //    {
            //        maas=maas+(cocukSayisi*2000);
            //        Console.WriteLine($"Sayın {ad} alacağınız maaş: {maas}");
            //    }
            //    else
            //    {
            //        maas=maas+(cocukSayisi*2500);
            //        Console.WriteLine($"Sayın {ad} alacağınız maaş: {maas}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Sayın {ad} alacağınız maaş: {maas+5000}");
            //}

            #endregion
            #region Ödev 2 
            //Ödev 2 if else
            // Kullanıcıdan 3 adet sayı alınız ve bu sayıları şekil A görüldüğü gibi 
            //büyükten küçüğe sıralı bir şekilde ekrana yazdırınız
            //Şekil a: 15 13 5

            //Console.WriteLine("1.Sayıyı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.Sayıyı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi>sayi2&&sayi>sayi3)
            //{
            //    Console.WriteLine("En büyük sayı: "+sayi);
            //    if (sayi2>sayi3)
            //    {
            //        Console.WriteLine("Ortanca sayı: "+sayi2);
            //        Console.WriteLine("En küçük sayı sayı: "+sayi3);
            //        //Console.WriteLine("En Büyük değer "+sayi +" > "+sayi2+" > "+sayi3);
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Ortanca sayı: "+sayi3);
            //        Console.WriteLine("En küçük sayı: "+sayi2);
            //    }

            //}
            //else if (sayi2>sayi&&sayi2>sayi3)
            //{
            //    Console.WriteLine("En büyük sayı: "+sayi2);
            //    if (sayi>sayi3)
            //    {
            //        Console.WriteLine("Ortanca sayı: "+sayi);
            //        Console.WriteLine("En küçük sayı: "+sayi3);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca sayı: "+sayi3);
            //        Console.WriteLine("En küçük sayı: "+sayi);
            //    }
            //}
            //else if (sayi3>sayi2&&sayi3>sayi)
            //{
            //    Console.WriteLine("En büyük sayı: "+sayi3);
            //    if (sayi2>sayi)
            //    {
            //        Console.WriteLine("Ortanca sayı: "+sayi2);
            //        Console.WriteLine("En küçük sayı: "+sayi);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca sayı: "+sayi);
            //        Console.WriteLine("En küçük sayı: "+sayi2);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar birbirine eşittir.");
            //}

            #endregion
            #region Ödev 3
            //int sayi3 = 0;
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    sayi3=sayi;

            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);//e.message yakalanan hatanın mesajını bize verir.
            //}
            //Console.WriteLine(sayi3);
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi);

            //Console.WriteLine("Cinsiyetiniz Giriniz (E/K)");
            //string cinsiyet = Console.ReadLine().ToUpper();

            //try// dene yakala  try catch hata yakalama yöntemidir.

            //{
            //    switch (cinsiyet)
            //    {
            //        case "E":
            //            Console.WriteLine("Yaş:");
            //            int yas = Convert.ToInt32(Console.ReadLine());
            //            if (yas>=60)
            //            {
            //                Console.WriteLine("Maaş:");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emekli ikramiyeniz: "+(maas*10));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Prin Gün Sayısı:");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim>=6000)
            //                {
            //                    Console.WriteLine("Maaş:");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emekli ikramiyeniz: {0}", (maas*11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu çalışmaya devam.");
            //                }
            //            }
            //            break;
            //        case "K":
            //            Console.WriteLine("Yaş:");
            //            int yas2 = Convert.ToInt32(Console.ReadLine());
            //            if (yas2>=58)
            //            {
            //                Console.WriteLine("Maaş:");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"Emeklilik ikramiyeniz: {maas*10}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayısı");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim>=5600)
            //                {
            //                    Console.WriteLine("Maaş:");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz: "+(maas*11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik hayal oldu.");
            //                }
            //            }
            //            break;
            //        default: Console.WriteLine("Yanlış tuşlama");
            //            break;
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Hata "+e.Message);
            //}

            #endregion
        }
    }
}
