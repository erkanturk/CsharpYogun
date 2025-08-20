namespace _26_Ref_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ref Odev
            //Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 
            //ref kullanılarak yapılacak ve dizinin tek elemanları çift elemanları ekrana yazdırılacak 
            //Toplamda 3 method yapısı kullanılacak Biri sadece diziyazdır methodu gelen diziyi yazdıracak 
            //Biri TekCift olacak bu method bir dizi bir tek sayılar dizisi bir çift sayılar dizisi alacak 
            //Dizi doldur yapısı olacak 3 parametreli olacak.
            #endregion
            /* Ref-methods bu yapıda referans olarak gösterdiğimiz bir değeri güncelleme yapmamızı sağlar dışarıda bir değer olması mutlaka zorunludur.
            Örneğin:Ben bakkaldan bir çikolata aldım fakat bakkal bu çikolatayı toptancıdan 10 tl ye aldı bana satarken
            fiyat 15 tl olarak güncellendi bu yapıda ref mantığı ile çalışmalıdır.

            Ref ile birden fazla değeri dışarı çıkarabiliriz
            Return bir değer dışarı çıkarırken Ref ve Out keywordleri birden fazla değer çıkarmamızı sağlar.

            */
            int sayi,sayi2, sayi3;
            //Console.WriteLine(sayi);//10
            //Refli(ref sayi);
            //Console.WriteLine(sayi);//15
            sayi = 10;
            sayi2 = 15;
            sayi3 = 20;
            Refli2(sayi, ref sayi2, ref sayi3);
            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);

        }
        static void Refli(ref int sayi)
        {
            Console.WriteLine(sayi);
            sayi=15;

        }
        static void Refli2(int sayi, ref int sayi2, ref int sayi3)
        {
            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);
            sayi=15;
            Console.WriteLine(sayi);
            sayi2=20;
            sayi3=30;
        }

    }
}
