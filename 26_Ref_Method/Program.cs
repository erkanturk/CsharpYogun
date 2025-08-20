namespace _26_Ref_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Ref-methods bu yapıda referans olarak gösterdiğimiz bir değeri güncelleme yapmamızı sağlar dışarıda bir değer olması mutlaka zorunludur.
            Örneğin:Ben bakkaldan bir çikolata aldım fakat bakkal bu çikolatayı toptancıdan 10 tl ye aldı bana satarken
            fiyat 15 tl olarak güncellendi bu yapıda ref mantığı ile çalışmalıdır.

            Ref ile birden fazla değeri dışarı çıkarabiliriz
            Return bir değer dışarı çıkarırken Ref ve Out keywordleri birden fazla değer çıkarmamızı sağlar.

            */
            //int sayi, sayi2, sayi3;
            ////Console.WriteLine(sayi);//10
            ////Refli(ref sayi);
            ////Console.WriteLine(sayi);//15
            //sayi = 10;
            //sayi2 = 15;
            //sayi3 = 20;
            //Refli2(sayi, ref sayi2, ref sayi3);
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);

            int[] sayilar = new int[15];
            int tekBoyut = 0;
            int ciftBoyut = 0;
            DiziDoldur(sayilar, ref tekBoyut, ref ciftBoyut);

            int[] tekSayilar = new int[tekBoyut];
            int[] ciftSayilar = new int[ciftBoyut];
            TekCift(sayilar, ref tekSayilar, ref ciftSayilar);

            DiziYazdir(sayilar); Console.WriteLine("Dizi elemanları");
            DiziYazdir(tekSayilar); Console.WriteLine("Tek sayılar");
            DiziYazdir(ciftSayilar); Console.WriteLine("Cift Sayılar");

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

        static void DiziDoldur(int[] array, ref int tekBoyut, ref int ciftBoyut)
        {
            Random random = new Random();
            for (int i = 0; i<15; i++)
            {
                int sayi = random.Next(1, 100);
                array[i] = sayi;
                if (sayi%2==0)
                {
                    ciftBoyut++;
                }
                else
                {
                    tekBoyut++;
                }
            }
        }
        static void TekCift(int[] array, ref int[] tekSayilar, ref int[] ciftSayilar)
        {
            foreach (int item in array)
            {
                if (item%2==0)
                {
                    int i = Array.IndexOf(ciftSayilar, 0);
                    ciftSayilar[i]=item;
                }
                else
                {
                    int i = Array.IndexOf(tekSayilar, 0);
                    tekSayilar[i]=item;
                }
            }
        }
        static void DiziYazdir(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
