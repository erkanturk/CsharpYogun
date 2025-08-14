namespace _21_Methods_Returns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = Topla();
            //Console.WriteLine(sayi);
            //Console.WriteLine(Topla());
            //Console.WriteLine(AdGoster());

            //foreach (int s in Yaslar())
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("Adınızı giriniz");
            //string ad = Console.ReadLine();
            //int adUzunluk = AdUzunluk(ad);
            //Console.WriteLine(adUzunluk);

            //Kullanıcıdan fiyat alalım ve kdv oranını soralım 
            //girdiği fiyata kdv uygulayan methodu yazalım ve ekranda yazdıralım
            //Console.WriteLine("Ürün fiyatı:");
            //double urunFiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Kdv oranı:");
            //double kdv = Convert.ToDouble(Console.ReadLine());
            // Kdv(urunFiyat, kdv);

            //KdvUygula();
            //Console.WriteLine(KdvLi());
            double fiyat = KdvLi2();
            Console.WriteLine("Kdv oranı:");
            double kdv = Convert.ToDouble(Console.ReadLine());
            fiyat*=kdv;
            Console.WriteLine(fiyat);
        }
        static void Kdv(double sayi, double sayi2)//Parametreli iş yapan dışarıdan gelen değerleri içinde işleme tabi tutar
        {
            Console.WriteLine(sayi*=sayi2);
        }
        static void KdvUygula()//Parametresiz iş yapan kullanıcı method içinde işlemleri yaptırır.
        {
            Console.WriteLine("Ürün fiyatı:");
            double urunFiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv oranı:");
            double kdv = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(urunFiyat*=kdv);
        }
        static double KdvLi()//kullanıcıdan aldığı değerleri geriye dönderir ve dışarı çıkan yapı ekranda yazılır
        {

            Console.WriteLine("Ürün fiyatı:");
            double urunFiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv oranı:");
            double kdv = Convert.ToDouble(Console.ReadLine());
            return (urunFiyat*=kdv);
        }
        static double KdvLi2()//kullanıcının girdiği ürün fiyatını dışarı çıkarıp kdv uygular ve ekrana yazdırır.
        {

            Console.WriteLine("Ürün fiyatı:");
            double urunFiyat = Convert.ToDouble(Console.ReadLine());

            return urunFiyat;
        }
        static int Topla()
        {
            return (10+20);
        }
        static string AdGoster()
        {
            return "Erkan Türk";
        }
        static int[] Yaslar()
        {
            int[] yaslar = { 20, 30, 40, 50, 60 };
            return yaslar;
        }
        static int AdUzunluk(string ad)
        {
            int uzunluk = ad.Length;
            return uzunluk;
        }
    }
}
