namespace _05_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*if else if else
              Koşul yapıları Contition
              switch case
            Bir programın akışı koşula göre haraket edecek ise if else yapısı kullanılır if veya else if bloklarından biri  çalışırsa diğer bloklar kontrol edilmez.
            */
            #region Örnekler
            //Kullanıcıdan 10 dan büyük bir sayı girmesini isteyelim ve ekrana girdiği değeri yazdıralım

            //Console.WriteLine("10 dan büyük bir değer giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 10) //true false değerine göre içindeki kod bloğunu çalıştırır.
            //{
            //    Console.WriteLine($"Sayınız: {sayi} 10'dan Büyük");
            //}
            //else
            //{
            //    Console.WriteLine($"Sayınız 10 dan küçüktür. {sayi}");
            //}
            //Kullanıcıdan bir değer alalım bu değerin pozitif mi negatif mi olduğunu bulalım.
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayınız Pozitiftir.");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Sayınız Negatiftir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayınız 0 dır.");
            //}
            //Tek koşul kapsamında bir if else yapısı yeterli olacaktır birden fazla if ile bu yapıyı tekrar tekrar kontrol etmek mantıksız olacaktır.
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayınız Pozitiftir.");
            //}
            //if (sayi < 0)
            //{
            //    Console.WriteLine("Sayınız Negatiftir.");
            //}
            //if(sayi==0)
            //{
            //    Console.WriteLine("Sayınız 0 dır.");
            //}

            //Console.WriteLine("Yaşınızı giriniz");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Branş");
            //string brans = Console.ReadLine().ToLower();


            //if (yas >= 18)
            //{
            //    Console.WriteLine("Not bilgisi");
            //    int not = Convert.ToInt32(Console.ReadLine());
            //    if (not >= 70)
            //    {

            //        if (brans == "yazılım")
            //        {
            //            Console.WriteLine("Bilgisayar Mühendisliği");
            //        }
            //        else if (brans == "makine")
            //        {
            //            Console.WriteLine("Makine Mühendisliği");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Mezun");
            //        }
            //    }
            //    else if (not >= 60)
            //    {

            //        if (brans == "yazılım")
            //        {
            //            Console.WriteLine("Büte kaldı");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Branşınıza ait yaz okulu bulunamadı.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kaldı");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Yaşınız Küçük");
            //}

            //Kullanıcıdan haftanın hangi günü olduğunu isteyelim
            //Kullanıcı 1 derse bize Pazartesi desin 2 salı olarak tüm günleri yazalım 
            //Kullanıcı 1 veya 7 dışında bir değer girerse 1 ila 7 arasında bir değer giriniz diye uyaralım.
            //if ()shift+enter ile {} bu yapıyı oluşturur. 
            //{

            //}
            //Console.WriteLine("Yaşınızı giriniz");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //        if (brans == "yazılım")
            //        {
            //            Console.WriteLine("Bilgisayar Mühendisliği");
            //        }
            //        else if (brans == "makine")
            //        {
            //            Console.WriteLine("Makine Mühendisliği");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Mezun");
            //        }

            //Console.WriteLine("Haftanın Hangi Günü ");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun < 1 || gun > 7)
            //{
            //    Console.WriteLine("Lütfen 1 ila 7 arasında bir değer giriniz");
            //}
            //else if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else
            //{
            //    Console.WriteLine("Pazar");
            //}
            #endregion
            //Kullanıcıdan 2 veya 2 den büyük  sayı isteyelim ve bu sayının tek mi çift mi olduğunu söyleyen programı yazalım eğer kullanıcı 2 den küçük bir değer girer ise uyarı verelim
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Çiftir");
            //}
            //else
            //{
            //    Console.WriteLine("Tektir");
            //}
            //kullanıcı giriş örneği

            string kad = "admin";
            string pass = "1453";

            Console.WriteLine("Kullanıcı adınızı giriniz");
            string kullaniciAdi = Console.ReadLine().ToLower();
            Console.WriteLine("Şifreniz:");
            string password = Console.ReadLine();

            if ((kullaniciAdi == kad || kullaniciAdi == "a") && password == pass)
            {
                Console.WriteLine("Sisteme giriş başarılı");
            }
            else//Else kısmında koşul belirtmeyiz çünkü geriye kalan tüm koşulları kapsar
            {
                if (kullaniciAdi != kad && kullaniciAdi != "a")
                {
                    if (pass != password)
                    {
                        Console.WriteLine("Şifre hatalı");
                    }
                    Console.WriteLine("Kulanıcı adı yanlıştır");
                }
                else
                {
                    Console.WriteLine("Şifreniz yanlıştır.");
                }
            }


        }
    }
}
