namespace _16_OtomatProjeVeOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ödev
            //Bir dizinin eleman sayısı 10 ile 20 arasında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,100 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizideki en büyük ve en küçük sayılar sort() kullanılmadan bulup ekrana yazdırılacak 
            #endregion
            #region Ödev method
            /*
            kullanıcıdan iki adet ürün fiyatı alınacak pahalı olan ürüne %30 indirim uygulanacak 
            kullanıcıya 3. ürünü almak ister misiniz diye soracağız eğer evet derse başka bir methoda yönlendirip 
            3. ürün fiyatı isteyeceğiz 3. ürüne de %50 indirim uygulayıp toplam 1.ürün 2.ürün(%30) 3.ürünün(%50) 
            fiyatlarını toplayıp 
            Ekrana toplam fiyatı yazdıracağız 
            Eğer istemez ise 3. ürünü 2 üründen pahalı olan fiyata indirim uygulayıp toplamı ekranda göstereceğiz.
            
            
            */
            #endregion
            /* 

         Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
        Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, 
            aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

         // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de 
            var ise eklenmeyecek yok ise eklenecek
           Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir 
            uyarısı veririp açıldığında bilgilendirecek
         */
            #region Otomat Projesi
            //bool admin = false;//Admin modunda mı ?
            //string pass = "123";//sistemde kayıtlı parola
            //string inputPassword;//kullanıcının girdiği değer
            //int wrongAttempts = 0;//yanlış giriş miktarı
            //bool locked = false;//hesap kitli mi ?
            //string[] products = { "kola", "fanta", "büsküvi", "çikolata", "kraker" };
            //double[] prices = { 60, 60, 40, 25, 30 };
            //double balance = 0; //kullanıcının girdiği para miktarı

            //while (true)
            //{
            //    try
            //    {
            //        for (int i = 0; i < products.Length; i++)
            //        {
            //            Console.WriteLine($"{i} - {products[i]}: {prices[i]}");//Ürün listesi
            //        }
            //        Console.WriteLine("Ürün Numarasını  Seçiniz (Admin Girişi İçin -1 e basınız.)");
            //        int productNo = Convert.ToInt32(Console.ReadLine());
            //        if (productNo==-1)
            //        {
            //            Console.Clear();
            //            if (!locked)
            //            {
            //                while (wrongAttempts<3)
            //                {
            //                    Console.WriteLine("Admin şifrenizi giriniz");
            //                    inputPassword = Console.ReadLine();
            //                    if (inputPassword==pass)
            //                    {
            //                        admin = true;
            //                        Console.Clear();
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        wrongAttempts++;
            //                        Console.WriteLine("Yanlış şifre ! Kalan Hakkınız: "+(3-wrongAttempts));
            //                    }
            //                    if (wrongAttempts==3)
            //                    {
            //                        Console.WriteLine("Yanlış giriş yapıldı Hesap 10 saniye kitlendi");
            //                        locked = true;
            //                        Thread.Sleep(10000);//10 saniye bekletme
            //                        locked = false;
            //                        wrongAttempts = 0;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hesap kitli lütfen bekleyin");
            //                Thread.Sleep(10000);
            //                locked= false;
            //            }
            //            continue;
            //        }
            //        Console.WriteLine("Para Girişi Yapınız:");
            //        balance=Convert.ToDouble(Console.ReadLine());
            //        if (balance>=prices[productNo])
            //        {
            //            Console.WriteLine("Ürünü aldınız.\nAfiyet Olsun.\nPara Üstü: "+(balance-prices[productNo]));
            //            Thread.Sleep(2000);
            //            balance=0;
            //            Console.Clear();
            //        }
            //        else
            //        {
            //            while (true)
            //            {
            //                Console.WriteLine("Yetersiz Bakiye!");
            //                Console.WriteLine("Para Ekle 1\nPara iade 2");
            //                int secim = Convert.ToInt32(Console.ReadLine());
            //                if (secim==1)
            //                {
            //                    Console.WriteLine("Para Ekle");
            //                    balance+=Convert.ToDouble(Console.ReadLine());
            //                    if (balance>=prices[productNo])
            //                    {
            //                        Console.WriteLine("Ürünü aldınız.\nAfiyet Olsun.\nPara Üstü: "+(balance-prices[productNo]));
            //                        Thread.Sleep(2000);
            //                        balance=0;
            //                        Console.Clear();
            //                        break;
            //                    }


            //                }
            //                else if (secim==2)
            //                {
            //                    Console.WriteLine("Para iade edildi");
            //                    Thread.Sleep(2000);
            //                    balance=0;
            //                    Console.Clear();
            //                    break;

            //                }
            //                else
            //                {
            //                    Console.WriteLine("Hatalı Tuşlama");
            //                    Thread.Sleep(2000);
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("Hata: "+ex.Message);
            //        Thread.Sleep(2000);
            //    }
            //    if (admin)//kullanıcı doğru bilgiyi girdiğinde değişken true olacak.
            //    {
            //        Console.Clear();

            //        while (true)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("************Admin Paneli************");
            //            Console.WriteLine("1 Ürün Ekleme\n2 Ürün Güncelleme\n3 Ürün Silme\n4 Ürün Listele\n5 Çıkış");
            //            int secim = Convert.ToInt32(Console.ReadLine());
            //            if (secim==1)
            //            {
            //                Console.WriteLine("Ürün Adını Giriniz:");
            //                string urunAdi = Console.ReadLine().ToLower();
            //                bool kontrol = false;
            //                for (int i = 0; i < products.Length; i++)
            //                {
            //                    if (products[i].ToLower()==urunAdi)
            //                    {
            //                        kontrol = true;
            //                        break;//eğer ürün bulundu ise dizimde varsa döngüden çık
            //                    }

            //                }
            //                if (kontrol)
            //                {
            //                    Console.WriteLine("Ürün zaten mevcut.");
            //                    Thread.Sleep(3000);
            //                    continue;
            //                }
            //                Console.WriteLine("Ürün fiyatı:");
            //                double fiyat = Convert.ToDouble(Console.ReadLine());
            //                Array.Resize(ref products, products.Length+1);
            //                Array.Resize(ref prices, prices.Length+1);
            //                products[products.Length-1]=urunAdi;
            //                prices[prices.Length-1]=fiyat;
            //                Console.WriteLine("Ürün eklendi.");
            //                Thread.Sleep(2000);



            //            }
            //            else if (secim==2)
            //            {
            //                for (int i = 0; i < products.Length; i++)
            //                {
            //                    Console.WriteLine($"{i} - {products[i]}: {prices[i]}");//Ürün listesi
            //                }
            //                Console.WriteLine("Güncellenecek ürün numarası:");
            //                int guncellenecekNo = Convert.ToInt32(Console.ReadLine());
            //                if (guncellenecekNo>=0&&guncellenecekNo<products.Length)
            //                {
            //                    Console.WriteLine("Yeni ürün adı:");
            //                    string yeniUrun = Console.ReadLine().ToLower();
            //                    Console.WriteLine("Yeni fiyat");
            //                    double yeniFiyat = Convert.ToDouble(Console.ReadLine());
            //                    products[guncellenecekNo]=yeniUrun;
            //                    prices[guncellenecekNo]=yeniFiyat;
            //                    Console.WriteLine("Ürün Güncellendi");
            //                    Thread.Sleep(2000);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Hatalı Seçim");
            //                }
            //            }
            //            else if (secim==3)
            //            {
            //                for (int i = 0; i < products.Length; i++)
            //                {
            //                    Console.WriteLine($"{i} - {products[i]}: {prices[i]}");//Ürün listesi
            //                }
            //                Console.WriteLine("Silinecek Ürün numarası");
            //                int silinecekNo = Convert.ToInt32(Console.ReadLine());
            //                if (silinecekNo>=0&&silinecekNo<products.Length)
            //                {
            //                    for (int i = silinecekNo; i < products.Length-1; i++)
            //                    {
            //                        products[i]=products[i+1];//i değeri örneğin 2. indexe +1 ise 3.index 3. indexdeki değeri
            //                        //2. index e aktar diyoruz.
            //                        prices[i]=prices[i+1];
            //                    }
            //                    Array.Resize(ref products, products.Length-1);
            //                    Array.Resize(ref prices, prices.Length-1);
            //                    Console.WriteLine("Ürün Silindi");
            //                    Thread.Sleep(2000);

            //                }
            //                else
            //                {
            //                    Console.WriteLine("Hatalı seçim");
            //                }
            //            }
            //            else if (secim==4)
            //            {
            //                for (int i = 0; i < products.Length; i++)
            //                {
            //                    Console.WriteLine($"{i} - {products[i]}: {prices[i]}");//Ürün listesi
            //                }
            //                Thread.Sleep(5000);
            //            }
            //            else if (secim==5)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hatalı seçim");
            //            }
            //        }
            //        admin=false;
            //    }
            //}

            #endregion
            #region Array örnek
            // 5 elemanlı double bir dizi olacak. Bu dizinin içindeki elemanları kullanıcıdan alacağız. 
            // Bu double dizi içinde ürün fiyatlarını tutacak yani haliyle gireceğimiz her değer bir ürün fiyatı olacak.
            // Girilen her ürüne %18 indirim uygulanacak ve bu ürünlerin indirim uygulanmış halleri toplanıp gösterilecek.

            //double[] urunFiyatlari = new double[5];
            //for (int i = 0; i<5;)
            //{
            //    Console.WriteLine($"{i+1}.ürün fiyatını giriniz");
            //    urunFiyatlari[i]=double.Parse(Console.ReadLine());
            //    i++;

            //}
            //double toplamUrunFiyat = 0;
            //foreach (double fiyat in urunFiyatlari)
            //{
            //    toplamUrunFiyat += fiyat*0.82;
            //}
            //Console.WriteLine($"Ürün fiyatlarına %18 indirim uygulanmış halleri: {toplamUrunFiyat}");

            #endregion
            #region kullanıcıdan ürün sayısı alıp her bir ürünü diziye ekleyip ürünleri gösteren dizi yapısını yazalım
            Console.WriteLine("Kaç adet Ürün aldınız:");
            int urunSayi = Convert.ToInt32(Console.ReadLine());
            string[] urunAdi = new string[urunSayi];
            double[] fiyat = new double[urunSayi];

            for (int i = 0; i<urunAdi.Length; i++)
            {
                Console.WriteLine($"{i+1}.Ürün adı");
                string urun = Console.ReadLine();
                Console.WriteLine($"{i+1}.Ürün fiyatı");
                double uFiyat = Convert.ToDouble(Console.ReadLine());

                urunAdi[i]=urun;
                fiyat[i]=uFiyat*1.18;

            }
            double toplam = 0;
            for (int i = 0; i<urunAdi.Length; i++)
            {
                toplam+=fiyat[i];
                Console.WriteLine($"Alınan: {urunAdi[i]}. Ürün ve Kdvli Fiyatı: {fiyat[i]}");
            }
            Console.WriteLine("Toplam ödenecek fiyat: "+toplam);
            #endregion
        }
    }
}
