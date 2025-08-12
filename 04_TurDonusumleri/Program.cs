namespace _04_TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veri tipi dönüşümleri
            /* 1.Bilinçsiz tür dönüşümleri */
            //int s = 123456789;
            //double s2 = s;

            //Console.WriteLine(s2);//int olarak tanımladığımız değeri double değişkene aktardık artık double olarak kullanabiliriz.

            //double sayi = 10;
            //int sayi2 = sayi;//Hata verir çünkü büyük boyutlu bir yapı küçük boyutlu yapıya aktarım yapamaz.
            //fakat bu tür durumda casting yöntemi kullanılır.
            //Bilinçli tür dönüşümü.
            //double sayi = 10;
            //int sayi2 = (int)sayi; //bu töntemde double sayının int uzunluğunu aşmadığını belirterek işleme tabi tutuyoruz.
            //double sayi = 10.5;
            //int sayi2 = (int)sayi;
            //Console.WriteLine(sayi2);//Eğer ondalıklı değer ise int tipine dönderilen küsüratlarından arındırılır.

            //string metin = "10";
            //int sayi = 10;
            //Console.WriteLine(metin + sayi);
            ////int sonuc = Convert.ToInt32(metin);//Convert işlemi.
            //int sonuc = int.Parse(metin);//aynı işlemi yapar.
            //Console.WriteLine(sonuc + sayi);

            //Console.WriteLine($"int: {uint.MaxValue} {uint.MinValue}");
            //Console.WriteLine($"int: {int.MaxValue} {int.MinValue}");

            //double sayi = 22.35;
            //int sayi2 = 22;
            //double sayi3 = Convert.ToDouble(sayi2);
            //Console.WriteLine(sayi2);

            //char harf = 'A';//Ascii table da bu değerin rakamsal karşılığı olduğu için bu yapı bize rakamsal olarak toplam verecektir.
            //int sayi = 11;
            //int sonuc = harf + sayi;
            //Console.WriteLine(sonuc);

            //char harf2 = Convert.ToChar(sonuc);
            //Console.WriteLine(harf2);

            //Örnek:
            //Kullanıcıdan 2 kardeşin yaşını alarak ortalamasını ekrana yazdırın
            //Console.WriteLine("1. Yaşı yazınız.");
            //int yas = Convert.ToInt32(Console.ReadLine());//Kullanıcının girdiği değeri değişkene atamamızı sağlayan yapı Console.ReadLine
            //Console.WriteLine("2.Yaşı giriniz");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //int sonuc = (yas + yas2) / 2;
            //Console.WriteLine(sonuc);
            //Array yapılarından önce string methodları anlatacağız.

            //string ad = "erkan";
            //string ad2 = "ERKAN";

            //bool karsilastir = ad == ad2;//F
            //bool karsilastir2 = ad.ToUpper() == ad2;
            //bool karsilastir3 = ad == ad2.ToLower();

            ////Console.WriteLine(karsilastir);
            ////Console.WriteLine(karsilastir2);
            ////Console.WriteLine(karsilastir3);
            //Console.WriteLine(ad.ToUpper());
            //Console.WriteLine(ad2.ToLower());

            //Console.WriteLine("Adınızı giriniz");
            //string ad = Console.ReadLine().ToLower();
            //Console.WriteLine("Soyadınızı giriniz");
            //string ad2 = Console.ReadLine().ToUpper();

            //Console.WriteLine(ad+ad2);
            //Console.WriteLine(ad+" "+ad2);

            /*DateTime Zaman*/
            //DateTime zaman = DateTime.Now;//Şimdiki zaman
            //Console.WriteLine(zaman);
            //Console.WriteLine(zaman.Year);
            //Console.WriteLine(zaman.Month);
            //Console.WriteLine(zaman.Day);
            //Console.WriteLine(zaman.Hour);
            //Console.WriteLine(zaman.Minute);
            //Console.WriteLine(zaman.Second);
            //Console.WriteLine(zaman.Microsecond);
            ////zaman.ToString("yyyy-MM-dd HH:mm:ss");
            //Console.WriteLine(zaman.ToString("yyyy-MM-dd HH:mm:ss"));//Yıl ay gün formatında getirir.

            //DateTime zaman = new DateTime(2000, 12, 01, 12, 34, 45);//new DateTime yapısı yeni bir zaman tipi oluşturmak istediğimizi belirtiyoruz.
            //Console.WriteLine(zaman);


        }

    }
}
