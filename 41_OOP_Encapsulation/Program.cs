namespace _41_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP Nedir
            /*Object Oriented Programming - Nesne Yönelimli Programlama
             * ilk yazılım sıralı satırlar olarak geliştiriliyordu
             * Sonrasında Class yapısı üzerinden geliştirilmeye başlandı ama hala büyük çaplı projeler yazılamıyordu
             * C dili =>Opp geliştirilmesi ile C++ dili ortaya çıktı
             * C++ gün geçtikçe popüleritesini kaybeden ama önceki yıllarda yazılış projeler üzerinde
             * hala geliştirilen çok güçlü bir dildir.
             * Makine diline en yakın dildir. siber güvenlik otomobil beyni vb işlemler için hala kullanılır
             * İnternet icadı ile birlikte Java ve C# dilleri ortaya çıktı
             * Bize sağladığı kolaylıklardan biri Oop yapısı ve Garbage Collector yapısıdır
             * OOP yapısı 4 temel prensip üzerine kuruludur
             * 
             * Enkapsülasyon (Encapsulation) kapsulleme
             * Inheritance (Kalıtım) miras alma
             * Polymorphism (Çok Biçimlilik)
             * Abstraction (Soyutlama)
             * 
             *     
             */
            #endregion
            #region Encapsulation (Kapsülleme)
            /* Nesnenin iç detaylarını gizleyerek, dışarıdan erişimi kontrollü hale getirmektir.
            *Bu sayede veri bütünlüğü korunur ve nesnenin kullanımı daha kolay daha güvenli hale gelir.
            *Doğrudan değişkene erişimi engelleyerek istenmeyen değer atamalarının önüne geçilir.
            *Özellikler aracılığıyla değer ataması yaparken gerekli kontrolleri gerçekleştirebiliriz.
            *Özellik (Property)
            *Sınıf içindeki özel alanlara kontrollü erişimi sağlar 
            *Propertylerin get ve set blokları vardır bu bloklar 
            *Get => var olan değeri okumak için kullanılır
            *Set => var olan değeri değiştirmek için kullanılır

            
            */
            #endregion

            /*** Ödev ***
            Bir banka hesabını temsil eden bir uygulama geliştirmek istiyoruz. 
            Bu uygulamada, hesap bakiyesi gizli tutulmalı ve sadece belirli
            işlemlerle (para yatırma ve çekme) değiştirilebilmelidir.
            Kapsülleme (encapsulation) prensibini kullanarak bakiyeye 
            doğrudan erişimi engelleyeceğiz ve işlemler sırasında gerekli kontrolleri yapacağız.

           Kapsülleme (Encapsulation): Verileri dışarıya karşı korumak ve kontrollü 
                    erişim sağlamak için kapsülleme prensibini kullanın.
           Veri Doğrulama: Metotlar içinde girilen tutarların geçerli olup olmadığını kontrol edin.
           Metot İsimlendirme: Metot isimlerinin anlamlı ve eylem odaklı 
            olmasına dikkat edin (örneğin, Deposit, Withdraw).
           */

            #region Örnek 1
            //string ogretmen = "e";
            //string password = "1";

            //Ogrenci ogrenci = new Ogrenci();
            ////ogrenci.vize;//hata verir çünkü vize feild yapısı private olarak tanımlandı
            ////ogrenci.final;//hata verir çünkü final feild yapısı private olarak tanımlandı
            //Console.WriteLine("Ogretmen için kullanıcı adınızı giriniz");
            //string kullanici = Console.ReadLine();
            //Console.WriteLine("Şifrenizi giriniz");
            //string sifre = Console.ReadLine();
            //if (kullanici==ogretmen&&password==sifre)
            //{
            //    Console.WriteLine("Öğrenci Vize notu");
            //    ogrenci._Vize=Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Öğrenci Final notu");
            //    ogrenci._Final=Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("Öğenci için kullanıcı adı ve şifrenizi giriniz");
            //string cevap = Console.ReadLine();
            //Console.WriteLine("Şifre");
            //string pass = Console.ReadLine();
            //if (cevap=="1"&&pass=="1")
            //{
            //    Console.WriteLine($"Finalden aldığınız not: {ogrenci._Final}");
            //    Console.WriteLine($"Vizeden  aldığınız not: {ogrenci._Vize}");
            //    Console.WriteLine($"Ortalaması: {ogrenci.Ortalama}");
            //}

            #endregion

            #region Örnek 2
            Araba araba = new Araba();
            araba._Hiz=200;
            araba.Hizlanma(10);
            araba.Hizlanma(10);
            araba.Hizlanma(10);
            araba.Hizlanma(10);
            araba.Hizlanma(10);
            araba.Hizlanma(10);

            Console.WriteLine(araba._Hiz);
            // araba.Hizlanma(350);//hız miktarn otomaik olarak 250 ye çekecek.
            // araba.Yavaslama(100);
            #endregion

        }
    }
    //class Ogrenci
    //{
    //    private int vize;//bu feild yapısı private olarak tanımlandığı için dışarıdan erişilemez
    //    private int final;//dışarıdan erişmek için kapsülleme yapısı ile kontrollü bir erişim sağlarız
    //    public int _Vize
    //    {
    //        get { return vize; }
    //        set
    //        {
    //            if (value>=0&&value<=100)
    //            {
    //                vize = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine("0-100 arasında bir değer giriniz");
    //                vize=0;
    //            }
    //        }

    //    }
    //    public int _Final
    //    {
    //        get { return final; }
    //        set
    //        {
    //            if (value>=0&&value<=100)
    //            {
    //                final = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine("0-100 arasında bir değer giriniz");
    //                final=0;
    //            }
    //        }
    //    }

    //    public double Ortalama
    //    {
    //        get { return vize * 0.4 + final * 0.6; }
    //    }

    //}

}
