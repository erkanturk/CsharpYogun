namespace _27_Out_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Out keyword
                Bir method parametresi out ile işaretlenmiş ise bu yapı dışarıya çıkış olarak belirtilmiştir
            bu yapı dışarıda null olabilir null bir değere atama yapılabilir
            Reften farklı olarak outda null değerlerle işlem yaparken Ref de ise bir değeri referans almalıyız.
            Gerçek hayattaki örneği şudur
            Ben bir işe başlayacağım fakat benim referansım yok yani yeni mezunum 
            bir işe başladım sonrasında artık o yer benim referansım oldu 
            Null bir değer artık null olmaktan çıktı son aldığı değeri göstermeye başladı.
            */
            //double sayi, sayi2, sayi3;
            //int s2, s3;

            //Outlu(out sayi, out sayi2, out sayi3);
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);
            //sayi=10;

            //Sayilar(ref sayi, out sayi2);
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //int s = Sayilar2(20, 20);
            //Sayilar2(out s2, out s3);
            //Console.WriteLine(s);
            //Console.WriteLine(s2+" "+s3);
            int s1, s2;
            int s = Sayilar3(out s1, out s2);
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            string sayi = "A";
            int n;
            int.TryParse(sayi, out n);
            Console.WriteLine(n);
            Console.WriteLine(sayi);

        }
        static void Outlu(out double sayi, out double sayi2, out double sayi3)
        {
            sayi=100;
            sayi2 = 200;
            sayi3 = 300;

            

        }
        static void Sayilar(ref double sayi, out double sayi2)
        {
            sayi*=1.68;//Referans aldığı bir değere kdv uygulama işlemi yapar
                       //sayi2*=1.22;//fakat out ile null bir değer bu işlemi yapamayız
            sayi2=(sayi*1.22);//burada değer geldiği için gelen değere işlem yapabiliriz.

        }
        static int Sayilar2(int sayi, int sayi2)
        {
            return sayi+sayi2;
        }
        static void Sayilar2(out int sayi, out int sayi2)
        {
            sayi=10;
            sayi2=20;

        }
        static int Sayilar3(out int sayi, out int sayi2)
        {

            sayi=20;//Null olarak gelen değerlere atama yapıldı
            sayi2=30;
            return sayi+sayi2;
        }

    }
}
