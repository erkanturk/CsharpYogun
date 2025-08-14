namespace _19_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Tanım

            /* Methodlar (Fonksiyonlar)
            Methodlar yapacağımız bir işi modüler hale getirmemizi sağlar. Her method bir iş yapar.
            Bu iş sonucu bir değerde dönebilir dönmeyedebilir. Aynı zamanda methodlar parametre alabilir yada almaya bilirler.
            Method içinde method tanımlaması yapılamaz.
            Methodlar telem olarak 2 ye ayrılır.
            1.Geriye değer döndürmeyen methodlar (void)
            2.Geriye değer döndüren methodlar (int,double,decimal ,bool,char,int[],char[],List,Class)
            parametreler methoda verilerek methodun daha dinamik ve parametrik olarak çalışmasını sağlar.
            Methodlar sadece çağrıldığı zaman çalışırlar çağırılmadığında kod olarak geçerliliği yoktur.
            Method isimleri benzersiz olmalıdır aynı isimde method olamaz eğer aynı isimde method var ise
            bu methodların imza tipleri farklı olmalıdır.

            Tanım
            Geriye değer döndürmeyen method tanımı
            void MethodAdi()
            {
            Yapılacak iş:
            }

             Geriye değer döndüren method tanımı
            int MethodAdi()
            {
            Yapılacak iş
            return ile bir iş sonucu yada bir işlem sonucu geriye döndermelidir ve mutlaka return kullanılmalıdır.
            return 10;
            }
             */
            #endregion

            //Yaz();//Method kullanım amacı bir defa tanımla ihtiyac durumunda kullan.
            //Yaz();
            //Yaz();
            //YazParametreli("Merhaba Parametreli Method");
            //string text = "C# Methodlar";
            //YazParametreli(text);

            //Yazdir("Erkan", "Türk", 31);

            //Dört işlem yapacak method oluşturalım bu methoda gelen değerleri aritmatik operatörlerle işleme
            //tabi tutsun ve ekranda sonuçlarını gösteren iş yapan parametreli methodları yazalım. 
            //İster kullanıcıdan değer alınacak ister sabit değerler gönderilecek.
            //Topla(20, 30);
            //Islem();
            //DiziDondur(20, 30, 40, 60, 70);//Dizi olarak benden parametre bekliyor fakat ben int değerler gönderiyorum
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            //DiziDondur(sayilar);
            string[] adlar = { "Erkan", "Ahmet", "İbrahim", "Burak" };
            char[] karakter = { 'a', 'b', 'c', 'd' };
            object[] a = { 1, 2, "metin", 'B', DateTime.Now, 3.5 };
            YapiDondur(adlar);
            YapiDondur(a);


        }
        static void YapiDondur(object[] dizi)
        {
            foreach (object item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziDondur(int[] dizi)
        {
            foreach (int d in dizi)
            {
                Console.WriteLine(d);
            }
        }
        static void Islem()
        {
            Console.WriteLine("1.Sayı değerini giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı değerini giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlem (|+|-|*|/|%|)");
            string islem = Console.ReadLine();
            if (islem=="+")
            {
                Topla(sayi, sayi2);
            }
            else if (islem=="-")
            {
                Cikart(sayi, sayi2);
            }
            else if (islem=="*")
            {
                Carp(sayi, sayi2);
            }
            else if (islem=="/")
            {
                Bol(sayi, sayi2);
            }
            else if (islem=="%")
            {
                Mod(sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama");
            }
        }
        static void Topla(double sayi, double sayi2)
        {
            Console.WriteLine(sayi+sayi2);
        }
        static void Cikart(double sayi, double sayi2)
        {
            Console.WriteLine(sayi-sayi2);
        }
        static void Carp(double sayi, double sayi2)
        {
            Console.WriteLine(sayi*sayi2);
        }
        static void Bol(double sayi, double sayi2)
        {
            if (sayi2!=0)
                Console.WriteLine(sayi/sayi2);
            else Console.WriteLine("Hata");
        }
        static void Mod(double sayi, double sayi2)
        {
            double deger = sayi%sayi2;

            Console.WriteLine(deger);
        }
        static void Yaz()//iş yapan parametresiz method
        {
            Console.WriteLine("Merhaba");
        }
        static void YazParametreli(string metin)//Parametreler methodlara gönderilmek zorundadır.
        {
            Console.WriteLine(metin);
        }
        static void Yazdir(string ad, string soyad, int yas)//neye ihtiyacımız var ise ona göre parametre belirtmeliyiz.
        {
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(yas);

            Console.WriteLine($"Adınız: {ad}\nSoyadınız: {soyad}\nYaşınız: {yas}");

        }

    }
}
