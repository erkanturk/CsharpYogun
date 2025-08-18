namespace _22_OdevCozum
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
            kullanıcıdan iki adet ürün fiyatı alınacak pahalı olan ürüne 
            %30 indirim uygulanacak 
            kullanıcıya 3. ürünü almak ister misiniz diye soracağız eğer 
            evet derse başka bir methoda yönlendirip 
            3. ürün fiyatı isteyeceğiz 3. ürüne de %50 indirim uygulayıp 
            toplam 1.ürün 2.ürün(%30) 3.ürünün(%50) 
            fiyatlarını toplayıp 
            Ekrana toplam fiyatı yazdıracağız 
            Eğer istemez ise 3. ürünü 2 üründen pahalı olan fiyata indirim 
            uygulayıp toplamı ekranda göstereceğiz.
            
            
            */
            #endregion
            #region Ödev1 Çözüm 
            //Random random = new Random();
            //int[] dizi = new int[random.Next(10, 21)];

            //int i = 0;
            //for (int j = 0; j<dizi.Length;)
            //{
            //    int sayi = random.Next(0, 20);
            //    bool varMi = false;
            //    foreach (var item in dizi)
            //    {
            //        if (item==sayi)
            //        {
            //            varMi =true;
            //            break;
            //        }
            //    }
            //    if (varMi==false)
            //    {
            //        dizi[i]=sayi;
            //        j++;
            //    }
            //}
            //while (i<dizi.Length)
            //{
            //    int sayi = random.Next(0, 20);
            //    bool varMi = false;
            //    foreach (var item in dizi)
            //    {
            //        if (item==sayi)
            //        {
            //            varMi =true;
            //            break;
            //        }
            //    }
            //    if (varMi==false)
            //    {
            //        dizi[i]=sayi;
            //        i++;
            //    }
            //}
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**************");
            //int enBuyuk = dizi[0];
            //int enKucuk = dizi[0];
            //foreach (int deger in dizi)
            //{
            //    if (deger>enBuyuk)
            //    {
            //        enBuyuk=deger;
            //    }
            //    if (deger<enKucuk)
            //    {
            //        enKucuk=deger;
            //    }
            //}
            //Console.WriteLine("En büyük eleman: "+enBuyuk);
            //Console.WriteLine("En küçük eleman: "+enKucuk);


            #endregion

            Indirim();
        }
        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatı");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat>fiyat2)
            {
                fiyat*=0.7;
            }
            else
            {
                fiyat2*=0.7;
            }
            Console.WriteLine("3. Ürünü Almak ister misiniz ?(1-E/2-H)");
            string cevap = Console.ReadLine().ToUpper();
            int input;//Null atama yapılmamış değişken
            if (int.TryParse(cevap, out input)&&input==1)
            {
                Indirim3(fiyat, fiyat2);
            }
            else if (input==2)
            {
                Console.WriteLine($"Ödeme: {fiyat+fiyat2}");
            }
            else
            {
                if (cevap=="E")
                {
                    Indirim3(fiyat, fiyat2);
                }
                else if (cevap=="H")
                {
                    Console.WriteLine($"Ödeme: {fiyat+fiyat2}");
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama");
                }
            }
            
        }
        static void Indirim3(double f1,double f2)
        {
            Console.WriteLine("3. ürün fiyatını giriniz");
            double f3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ödeme: {f1+f2+(f3/2)}");
        }
    }
}
