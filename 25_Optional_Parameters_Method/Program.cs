namespace _25_Optional_Parameters_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Optional Parameters bir methoda parametre vermeden de kullanılabilir bu yapı isteğe bağlı parametre yapısı ile belirtilmelidir bu yapının kendi içerisinde bir değer olur ve bu değer eğer parametre verilmezse varsayılan değer olarak
            gelir bu değer eğer verilirse gelen değer kalıcı değer olarak ayarlanır.
            opsiyonel yapı methodun son değerleri olmak zorundadır bu yapıdan sonra normal parametre tanımlaması yapılamaz.
            
            */
            Yaz("test");
            Console.WriteLine("Adınız:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            //Optional(ad, soyad, yas, "İngiltere");
            //Optional2(ad, soyad, yas, "", "Erkek");//istediğimiz parametreye değer vermek istediğimizde bu yapıda method yapılarını kullanmamız gerekiyor.

            Insan(ad, soyad, yas, ulke: "İngiltere", sehir: "Londra");//Kullanıcıdan aldığımız local değerler değişkenle methoda parametre olarak gönderilir.
            Insan(ad: "Erkan", soyad: "Türk", yas: 31, meslek: "Yazılım");//methodun kendi parametresine değer atanılarak istediğimiz değerleri istediğimiz parametrelere veriyoruz.

        }
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }

        static void Optional(string ad, string soyad, int yas, string ulke = "Türkiye")
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş; {yas} Ulke: {ulke}");
        }
        static void Optional2(string ad, string soyad, int yas, string ulke = "Türkiye", string cinsiyet = "belirtmek istemiyor")
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş; {yas} Ulke: {ulke} Cinsiyet: {cinsiyet}");
        }
        static void Insan(string ad, string soyad, int yas, string ulke = "Türkiye", string meslek = "Serbes Meslek", string sehir = "Istanbul")
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş; {yas} Ulke: {ulke} Meslek: {meslek} Şehir: {sehir}");
        }
        //static void Optional2(string ad, string soyad, int yas, string ulke = "Türkiye",string cinsiyet)
        //{//Hata verir çünkü parametre değeri gelmeyecektir bu yapıda yapmamız gereken opsiyonel yapılar sonda alacağımız parametreler başta olması gerekmektedir.
        //    Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş; {yas} Ulke: {ulke}");
        //}
    }
}
