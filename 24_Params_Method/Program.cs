using _23_OverLoad_Methods;

namespace _24_Params_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();//Başka projeden bir sınıf yapısı dahil etme yöntemi
            //test.Kullan();//bu yapıyı Alt+Enter ile projeyi referans olarak gösteririz
            //Ve using kısmında yapımıza dahil olur.
            /* Params Method 
            Bir method belirtilen sayıda parametre alabilir fakat bu yapı özelleştirilebilir
            Params keywordu bu yapının belirtilen veri tipinde sınırsız sayıda parametre 
            almasını sağlayan bir yapıdır 
            bu yapı methodun daima son parametresi olmak zorundadır ve
            verdiğimiz son parametre params olarak işaretlenmelidir.
            */
            //Parametre("Merhaba", "C#");
            //Paramsli("Merhaba", "C#", "Methodları", "Params", "Yapısı", "Görüyoruz");
            //Paramsli2("Merhaba", true, false, 'A', 10.5m, 10.5f, 10.3, 20, DateTime.Now);

            //int[] sayilar = { 1, 2, 3 };
            ////DiziYazdir(sayilar);//Bu yapı sadece dizi yapısı alır.
            ////DiziYazdir(10, 20, 30, 40);//bu yapıya bu şekilde int değerler gönderemeyiz
            //DiziYazdir2(sayilar);//Fakat DiziYazdir2 yapısı params olarak işaretlendiği için
            ////bu yapı artık hem sayı hem dizi yapısını bana dönderebilir.
            //DiziYazdir2(10, 20, 30, 40, 50);
            //DiziYazdir3(20, 10, 'A', DateTime.Now, "test", true, sayilar[1]);
            //DiziYazdır3 object params ile işaretlendiği için içerisinde her tipi 
            //sınırsız sayıda alabilir.


        }
        static void DiziYazdir(int[] sayilar)
        {
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziYazdir2(params int[] sayilar)
        {
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziYazdir3(int sayi, int sayi2, params object[] objects)
        {
            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sayi+" "+sayi2);
        }
        //static void Parametre(string metin, string metin2)
        //{
        //    Console.WriteLine(metin+" "+metin2);
        //}
        //static void Paramsli(string metin, params string[] metin2)
        //{
        //    Console.WriteLine(metin);
        //    foreach (string item in metin2)
        //    {
        //        Console.Write(item);
        //    }
        //}
        //static void Paramsli2(params object[] metin2)
        //{

        //    foreach (var item in metin2)
        //    {
        //        Console.WriteLine(" "+item);
        //    }
        //}
        //Params yapısı sonda belirtir.
        //static void Paramsli2(params object[] metin2,string metin)
        //{

        //    foreach (var item in metin2)
        //    {
        //        Console.WriteLine(" "+item);
        //    }
        //}
    }
}
