namespace _09_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch Case yapısı da if else yapısı gibi bir koşul yapısıdır.
            //If else yapısından farklı olarak koşul değeri bir karşılaştırma olarak yapılmaz 
            // girilen değeri case bloklarında arar ve o değere uygun case varsa çalışır.
            //eğer uygun case yoksa default blok çalışır.
            /*
            switch(değer)
            {
                case koşul: yapılacak işlemler;break; 
                case kosul2:yapılacak işlemler;break;
                case kosul3:yapılacak işlemler;break;
                default: geriye kalan herşeyi kapsar ;break;
            }
            switch kısmı deper kısmını kontrol edecek değişken yazılır.
            ve bu değişken uygun case e yönlendirilir.
            */
            #region Switch Case Örnekleri
            Console.WriteLine("Şehir gir plaka bul");
            string sehir = Console.ReadLine().ToLower();

            switch (sehir)
            {
                case "istanbul": Console.WriteLine($"{sehir}' Plakası 34"); break;
                case "ankara": Console.WriteLine($"{sehir}' Plakası 06"); break;
                case "izmir": Console.WriteLine($"{sehir}' Plakası 35"); break;
                case "bursa": Console.WriteLine($"{sehir}' Plakası 16"); break;
                case "konya": Console.WriteLine($"{sehir}' Plakası 42"); break;
                case "ısparta": Console.WriteLine($"{sehir}' Plakası 32"); break;
                case "kastamonu": Console.WriteLine($"{sehir}' Plakası 37"); break;
                case "niğde": Console.WriteLine($"{sehir}' Plakası 51"); break;
                case "amasya": Console.WriteLine($"{sehir}' Plakası 05"); break;
                default:
                    Console.WriteLine("Sistemde yaşanan yoğunluk sebebiyle bilgiye ulaşılamadı.");
                    break;
            }
            #endregion

            #region Kullanıcı market simülasyonu
            Console.WriteLine("Yapmak istediğiniz işlemi Yazınız");
            string islem = Console.ReadLine().ToLower();

            switch (islem)
            {
                case "stok eksilt": Console.WriteLine("Stok eksiltme yapıldı"); break;
                case "ürün ekle": Console.WriteLine("Ürün stoğa eklendi"); break;
                case "satış yap": Console.WriteLine("Satış yapıldı"); goto case "stok eksilt";
                default: Console.WriteLine("Hatalı seçim"); break;
            }
            //goto ile birden fazla case bloğuna gönlendirme yapabiliriz goto dedikten sonra hangi case e yönlendirecek
            //isek o case i yazmamız gerekiyor.

            #endregion
            #region gün yapısı
            //Kullanıcıya haftanın hangi günü diye soralım kullanıcının girdiği değere göre case yapısı bize
            //Pazartesi , Salı  diye değer döndersin eğer 1 ila 7 arasında değer girmezse default kısmı uyarı versin
            //1 ila 7 arasında değer giriniz diye.
            //Console.WriteLine("Haftanın hangi günü");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //switch (gun)
            //{
            //    case 1: Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); goto case -1;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;
            //    case -1: Console.WriteLine("Cumaya git:"); break;
            //    default:
            //        Console.WriteLine("Hatalı işlem 1-7 arasında değer giriniz");
            //        break;
            //}
            #endregion
            #region Basit hesap makinesi
            //Console.WriteLine("1.Sayıyı giriniz");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı giriniz");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlemi belirtin(+,-,*,/)");
            //char islem = Convert.ToChar(Console.ReadLine());

            //switch (islem)
            //{
            //    case '+': Console.WriteLine("Toplama Sonucu: "+(sayi1+sayi2)); break;
            //    case '-': Console.WriteLine("Çıkarma sonucu: "+(sayi1-sayi2)); break;
            //    case '*': Console.WriteLine($"Çarpma sonucu: {sayi1*sayi2}"); break;
            //    case '/':
            //        if (sayi2!=0)
            //        {
            //            Console.WriteLine($"Bölme Sonucu: {sayi1/sayi2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hiç bir sayı 0 a bölünemez");
            //        }
            //        break;
            //    default: Console.WriteLine("Hatalı Seçim"); break;

            //}





            #endregion

            #region Switch case
            Console.WriteLine("Cinsiyetinizi giriniz");
            string cinsiyet = Console.ReadLine();

            switch (cinsiyet)
            {
                case "erkek":
                    Console.WriteLine("Askerliğini yap mı ");
                    string cevap = Console.ReadLine();
                    if (cevap=="e")
                    {
                        Console.WriteLine("Çalışmaya başla");
                    }
                    else
                    {
                        Console.WriteLine("Askerliğini yap");
                    }
                    break;
                case "kadın":
                    Console.WriteLine("Okuyor musun ?");
                    string cevap2 = Console.ReadLine();
                    if (cevap2=="e")
                    {
                        Console.WriteLine("Hangi bölüm");
                    }
                    else
                    {
                        Console.WriteLine("Okumalısın");
                    }
                    break;
                default: Console.WriteLine("Hatalı değer"); break;
            }
            #endregion
        }
    }
}








