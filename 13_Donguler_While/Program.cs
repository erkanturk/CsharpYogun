namespace _13_Donguler_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Kullanıcıdan 0 girene kadar pozitif sayılar girmesini isteyin 0 girilene kadar girilen pozitif sayıları toplasın
            //ve ortalamasını hesaplasın
            //kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın
            //!!!!!*****Kullanıcı ilk değeri 0 girerse tekrar sayı giriniz desin*****!!!
            //!!!!!*****Kullanıcı negatif sayı girerse Lütfen Pozitif sayı giriniz!! uyarısı versin ve tekrar sayı girmeye yönlendirsin
            #endregion
            /* While (Loops) While döngüsü koşul true olduğu sürece çalışan bir döngü yapısıdır bu yapı 
            For ve do while yapısından farklı olarak bir koşul üzerinden çalışır do while da ki gibi yapıp kontrol etme mantığı yoktur
            yada for da ki gibi i <10 gibi bir yapısı hazır olarak bulunmaz manuel olarak yapıyı tanımlamamız gerekir sayı artışıda dahil


            */
            #region Döngü yapıları
            //1 den 10 a kadar değerleri yazdıran while döngüsü
            //int sayac = 1;
            //while (sayac<11)
            //{
            //    Console.WriteLine("While: "+sayac);
            //    sayac++;
            //}
            ////Console.WriteLine("***************");
            ////for (int i = 1; i < 11; i++)
            ////{
            ////    Console.WriteLine("For: "+i);
            ////}
            //sayac = 1;//Sayaç miktarını burada yeniden set ediyoruz çünkü while da sayaç miktarı 11 ulaştı ve koşul false oldu
            ////eğer tekrardan set etmezsek bu alan bize sadece do tarafında koşul false olarak dönüp 11 i yazdıracak.
            //Console.WriteLine("**************");
            //do
            //{
            //    Console.WriteLine("Do While: "+sayac);
            //    sayac++;
            //} while (sayac<11);
            //Console.WriteLine(sayac);
            #endregion


            #region Continue break;
            //int sayac = 1;
            //while (sayac<11)
            //{
            //    Console.WriteLine(sayac);
            //    if (sayac==5)
            //    {
            //        break;//break döngüyü sonlandırır.
            //    }
            //    sayac++;
            //}
            //int sayac = 0;
            //while (sayac <11)
            //{
            //    sayac++;
            //    if (sayac==5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(sayac);

            //}
            //int sayac = 0;
            //while (sayac <11)
            //{
            //    sayac++;
            //    if (sayac==5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(sayac-1);//0 değerinide görmek istiyorsak bu mantıkla ilerlememiz gerekiyor.

            //}
            #endregion

            #region 200 den başlayarak 0 a kadar olan ve 3'ün katı olan sayıları ekrana yazdıran while döngüsü
            //int sayi = 200;
            //while (sayi>0)
            //{
            //    if (sayi%3==0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    sayi--;
            //}
            #endregion

            #region 1 ila 10 arasındaki sayıların toplamını ekrana yazdıran while döngüsünü yazınız.
            //int i = 1;
            //int toplam = 0;
            //while (true)
            //{
            //    if (i<10)
            //    {
            //        toplam+=i;

            //    }
            //    else if (i==10)
            //    {
            //        break;

            //    }
            //    i++;
            //}
            //Console.WriteLine(toplam);
            #endregion

            #region Kullanıcıya kayıtlı user name ve şifre giriş paneli için 3 hak giriş yapma sistemi
            //eğer kullanıcı 3 hakkıda yanlış girer ise 10 saniye sistemi kitleyip tekrardan süre dolunca kullanıcı girişi istesin
            //string userName = "admin";
            //string password = "a123";
            //int hak = 3;
            //while (hak>0)
            //{
            //    Console.WriteLine("Kullanıcı Adınız");
            //    string kad = Console.ReadLine().ToLower();
            //    Console.WriteLine("Şifreniz");
            //    string pass = Console.ReadLine().ToLower();
            //    hak--;
            //    if (kad==userName&& password==pass)
            //    {
            //        Console.WriteLine("Giriş Başarılı !!!!");
            //        break;
            //    }
            //    else if (hak==0)
            //    {
            //        Console.WriteLine("Giriş hakkınız kalmadı...");
            //        Console.WriteLine("Sistem kitlendi");
            //        Thread.Sleep(10000);//Thread.Sleep Sisteme bir bekleme ekliyor delay gibi gecikme de diyebiliriz
            //        //verdiğimiz mili saniye cinsinden değeri alır o süre boyunca sistemi bekletir altındaki kodları okumaz 
            //        //süre dolana kadar.
            //        Console.Clear();//Console tarafındaki tüm eski yazıları temizler temiz bir sayfa açar.
            //        Console.WriteLine("Sistem açıldı");
            //        hak=3;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş başarısız.");
            //        Console.WriteLine("Tekrar deneyiniz");

            //    }

            //}
            #endregion


            #region Ödev Çözüm
            int sayac = 0;
            int toplam = 0;
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi==0&&sayac==0)
                {
                    continue;
                }
                if (sayi==0)
                {
                    break;
                }
                if (sayi<0)
                {
                    Console.WriteLine("Lütfen Pozitif değer giriniz");
                    continue;
                }
                toplam+=sayi;
                sayac++;
            }
            Console.WriteLine("Toplam: "+toplam);
            Console.WriteLine("Ortalama: "+(toplam/sayac));

            #endregion

        }
    }
}
