namespace _28_Recursive_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Recursive Method
            Bir işin tamamını yapmak yerine bir işi parçalı halde tamamlayan bir yapıdır
            Bu yapı methodun kendi içerisinde tekrar etme sonucu ile oluşur 
            Method bir döngü yapısı gibi bir işi sürekli çalıştırır fakat bu alanda verdiğimiz koşullar doğrultusunda program bir işin tamamını yapmak yerini parçalı bir halde tamamlar.
            Yinelenen method
            */
            //Yaz();

            Console.WriteLine("Çoklu form için 1 e basınız tekli form için 2 ye basınız");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi==1)
            {
                int s = 0;
                Console.WriteLine("Kaç adet Olsun");
                int s2 = Convert.ToInt32(Console.ReadLine());
                CokluForm(s2, s);
            }
            else if (sayi==2)
            {
                TekliForm();
            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama");
            }

        }
        static void TekliForm()
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            string yas = Console.ReadLine();
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas}");
        }
        static void CokluForm(int s, int s2)
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            string yas = Console.ReadLine();
            if (s>s2)
            {
                CokluForm(s-1, s2);
            }
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas}");
        }
        //static void Yaz()
        //{
        //    Console.WriteLine("Tekrar ediyorum");
        //    Yaz();
        //}
    }


}
