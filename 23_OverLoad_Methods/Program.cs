namespace _23_OverLoad_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region method çeşitleri
            //Void İş yapan
            //Değer Döndüren veri tipi olan methodlar return
            //OverLoad summary yapısı
            //Params 
            //Optional Parameters 
            //Recursive
            //Ref yapısı
            //Out yapısı
            #endregion
            /*OverLoad Methods 
            İmza tipleri farklı isimleri aynı olurlar 
            Aynı imza tipini barındıramazlar
            Hangi yapı kullanılacak ise o overload method devreye girer.
            İmza tipleri int,double ,decimal ,bool,ArrayList string Class v.b. yapılar imza
            tipi olarak adlandırılır bu yapılar benzersiz olmalıdır.
            OverLoad Yapı aslında OOP Dediğimiz Object Oriented Programing Tarafındaki Polymorphism i destekler
            Yani Statik çok biçimciliğe bir örnektir.
             */
            /* Summary Methods Summary yapısı developerların bilgilendirme için 
            methodlara verdiği açıklama yapılarıdır.
            
            */
            #region OverLoad
            //Console.WriteLine();//Kendisi ile birlikte toplamda 18 aşırı yüklemesi vardır.
            //Yaz();
            //Yaz(20);
            //Yaz("Merhaba C#");
            //Yaz(20, 30, 30);
            //Yaz(20, 20);
            //Yaz('A', 25, 33.5);
            //Yaz("test", 25);

            ////int sayi = 168;
            ////char deger =Convert.ToChar(sayi);
            ////Console.WriteLine(deger);

            //int[] sayilar = { 10, 20, 30, 40 };
            //double[] doubles = { 22.5, 23.5, 33.5 };
            //string[] adlar = { "Tahsin", "Onur", "Altan", "Erkan" };
            //Yaz(sayilar,doubles,adlar);
            #endregion
            //4farklı değer alan method yapısı yapalım bu yapılar 
            //Toplama,çıkarma ,çarpma ,bölme olsun
            //bu yapılar overload olacak şekilde yazalım ve gönderdiğimiz
            //parametrelere göre işlem yapsın
            //Her method 2 parametre alsın
            //Islem(20,20.5);
            Islem(20.5, 20.5);
            Yaz("test");
        }

        public static void Kullan()
        {
            Console.WriteLine("Bir değer giriniz");
        }
        static void Islem(int s, int s2)
        {
            Console.WriteLine(s+s2);
        }
        static void Islem(double s, int s2)
        {
            //int s3= (int)s;//casting
            Console.WriteLine(s*s2);
        }
        /// <summary>
        /// ilk değeri int 2.değer double bu değerleri çıkarır ve sonucu yazdırır.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="s2"></param>
        static void Islem(int s, double s2)
        {
            Console.WriteLine(s-s2);
        }
        /// <summary>
        /// Bu method double iki sayıyı alır ve bu yapıyı bölme işlemi yaparak sonucu yazdırır.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="s2"></param>
        static void Islem(double s, double s2)
        {
            Console.WriteLine(s/s2);
        }

        /// <summary>
        /// 
        /// </summary>
        static void Yaz()
        {
            Console.WriteLine("Merhaba OverLoad");
        }
        /// <summary>
        ///  <see href="https://www.ucuncubinyilerp.com/Account/Login"/>
        ///    Link bırakıp o linke de gidebiliriz.
        /// </summary>
        /// <param name="metin"></param>
        ///
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Yaz(string metin, int sayi)
        {
            Console.WriteLine(metin+" "+sayi);
        }
        static void Yaz(int sayi)
        {
            Console.WriteLine(sayi);
        }
        static void Yaz(int sayi, int sayi2)
        {
            Console.WriteLine(sayi+sayi2);
        }
        static void Yaz(double sayi, double sayi2, double sayi3)
        {
            Console.WriteLine(sayi*sayi2*sayi3);
        }
        static void Yaz(char harf, int sayi, double sayi2)
        {
            Console.WriteLine(harf+" "+(sayi+sayi2));
        }
        static void Yaz(int[] dizi, double[] dizi2, string[] dizis)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dizis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
