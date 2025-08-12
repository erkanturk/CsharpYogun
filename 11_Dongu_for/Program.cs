namespace _11_Dongu_for
{
    internal class Program
    {//https://www.w3schools.com/cs
        static void Main(string[] args)
        {
            //For döngüsü
            /* Tüm döngü yapıları True olduğu sürece çalışır.
                for(veri tipi = değer ; koşul<değer;artış veya azalış; )
                {
                }
            
            
            */
            #region For örnekler
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Erkan");
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (string deger = "a" ; deger < "z"; deger++)
            //{
            //hata verir bu alan rakamsal değerlerle çalışır.
            //}
            //for (char harf = 'A'; harf <= '~'; harf++)
            //{
            //    Console.WriteLine(harf);
            //}

            //0 dan başlıyarak 100 e kadar 2 nin katlarını ekrana yazdırın 
            //for (int i = 0; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //100 den başlayarak 0 a kadar 2 nin katlarını ekrana yazdırın
            //for (int i = 100; i >= 0; i-=2)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            // 1 ile 20 arasındaki sayıları ekrana yazdıran for döngüsü yapalım 
            //fakat burada eğer sayı 15 veya 16 ise bu sayıları ekrana yazdırmayalım
            //ve sayı 19 oldu ise döngüyü sonlandıralım
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i==15||i==16)
            //    {
            //        continue;//Continue komutu bizi for  döngüsüne tekrardan yönlendirir.
            //    }
            //    if (i==19)
            //    {
            //        Console.WriteLine(i);
            //        break;//break komutu bulunduğu döngüyü sonlandırır.
            //    }
            //    Console.WriteLine(i);
            //}


            for (int j = 0; j <=5; j++)
            {
                Console.WriteLine($"J döngüsü {j}");
                for (int i = 0; i <= 5; i++)
                {
                    if (i==2||i==3)
                    {
                        continue;//Continue komutu bizi for  döngüsüne tekrardan yönlendirir.
                    }
                    if (i==4)
                    {
                        Console.WriteLine(i);
                        break;//break komutu bulunduğu döngüyü sonlandırır.
                    }
                    Console.WriteLine(i);
                }
            }
            //for (int sayi = 0; sayi <= 10;)
            //{
            //    Console.WriteLine("Merhaba");

            //}

        }

    }
}
