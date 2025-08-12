namespace _10_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Loops Döngüler Do while döngüsü sadece c# a özgü bir döngüdür ve bu döngü yapısının 
             * mantığı do tarafı işlemi bir defa da olsa yapar 
            eğer koşul true değilse tek seferde işlem sonlanır eğer koşul true ise işlemi yapmaya devam eder.
              
            Döngü çeşitleri While,Do While ,For,(Foreach)=> bir koleksiyon yapısı ile çalışır

            do while kullanımı 
            do
            {
                Yaptırılacak işlemler
            }
            while (koşul);
            */

            #region döngüsüz if örneği
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
            #endregion
            #region döngülü if örneği
            //int sayi = 1;
            //int tekToplam = 0;
            //int ciftToplam = 0;

            //do
            //{
            //    Console.WriteLine($"{sayi}.Değeri giriniz");
            //    int deger = Convert.ToInt32(Console.ReadLine());

            //    if (deger%2==0)
            //    {
            //        ciftToplam += deger;
            //    }
            //    else
            //    {
            //        tekToplam+= deger;
            //    }
            //    sayi++;

            //}
            //while (sayi<=0);//koşul true olursa sonsuz döngü olur.
            //Console.WriteLine("Tek Toplam: "+tekToplam);
            //Console.WriteLine("Çift Toplam: "+ciftToplam);
            #endregion

            #region do while örneği
            //int sayi = 1;
            //int sayi2 = 2;
            //do
            //{
            //    Console.WriteLine("Merhaba");
            //} while (sayi>sayi2);//durum false olduğu için sadece bir defa çalışır.
            #endregion
            //int ciftToplam1 = 0;
            //do
            //{
            //    Console.WriteLine($"{sayi}.Değeri giriniz");
            //    int deger = Convert.ToInt32(Console.ReadLine());
            //    if (deger%2==0)
            //    {
            //        ciftToplam1 += deger;
            //    }
            //    else
            //    {
            //        tekToplam+= deger;
            //    }
            //    sayi++;
            //}
            //while (sayi<=6);//koşul true olursa sonsuz döngü olur.
            //Console.WriteLine("Tek Toplam: "+tekToplam);
            //Console.WriteLine("Çift Toplam: "+ciftToplam1);
            #region Kullanıcı 0 girene kadar kullanıcıdan sayi isteyen do while döngüsü
            ////kullanıcının her girdiği sayıyı toplayalım kullanıcı 0 a basarsa toplam ekrana yazılsın
            //int sayi1;
            //int  toplam = 0;
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz Çıkış için 0 a basınız");
            //    sayi1 =Convert.ToInt32(Console.ReadLine());
            //    toplam+=sayi1;

            //} while (sayi1!=0);
            //Console.WriteLine("Toplam değer: "+toplam);
            #endregion

            #region Random sayılar ile do while döngüsü
            //1-100 arasında rasgele üretilen sayıyı 5 hakta bulma oyunu



            //Random random = new Random();
            //int tutulanSayi = random.Next(1, 101);
            //int girilenSayi = 0;//int sayi; bu null bir değerdir 
            //int hak = 1;
            //do
            //{
            //    Console.WriteLine($"{hak}. hakkınız. Lütfen sayı giriniz");
            //    girilenSayi=Convert.ToInt32(Console.ReadLine());

            //    if (girilenSayi>tutulanSayi)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı giriniz");
            //    }
            //    else if (girilenSayi<tutulanSayi)
            //    {
            //        Console.WriteLine("Daha büyük bir sayı giriniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("tebrikler doğru tahmin");
            //    }
            //    if (hak==5)
            //    {
            //        Console.WriteLine($"Hakkınız Doldu Aradığınız sayı: {tutulanSayi}");
            //        //break ifadesi döngüyü sonlandırma işlemi yapar bu alana geldiğinde döngü sonlanır
            //        Thread.Sleep(5000);
            //        Console.WriteLine("Devam etmek istiyor musunuz (E/H) ?");
            //        string cevap = Console.ReadLine().ToLower();
            //        if (cevap=="e")
            //        {
            //            hak = 0; //hak sayısını 1 e eşitleyerek oyunu yeniden başlatıyoruz
            //            tutulanSayi = random.Next(1, 101); //tutulan sayıyı yeniden rastgele bir sayı ile değiştiriyoruz
            //        }
            //        else if (cevap=="h")
            //        {
            //            Console.WriteLine("Teşekkür ederiz.");
            //            break;
            //        }

            //    }
            //    hak++;
            //} while (girilenSayi!=tutulanSayi &&hak<=5);

            #endregion

            #region örnek 2
            //int sayi = 1; diye bir değişkenimiz olsun bu sayı 1 den başlayıp 10 a kadar tüm değerleri
            //ekrana yazdırsın.
            //int s = 1;

            //do
            //{
            //    Console.WriteLine(s);
            //    s++;
            //} while (s<=10);


            #endregion
        }
    }
}
