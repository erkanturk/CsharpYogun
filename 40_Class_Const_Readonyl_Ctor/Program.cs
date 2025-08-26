namespace _40_Class_Const_Readonyl_Ctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 10;
            //sayi = 20;
            //Console.WriteLine(sayi);

            //const int sayi2 = 30;//ilk tanımlandığında aldığı değer asla değiştirilemez
            //                     // sayi2 = 40;
            //Console.WriteLine(sayi2);
            ReadOnlyTest readOnlyTest = new ReadOnlyTest();
            // readOnlyTest.Deger=10;//Readonly yapısı  Sadece okuma işlemi yapar
            //değer ataması yapılamaz
            Console.WriteLine(readOnlyTest.Deger);

            ConstTest constTest = new ConstTest();
            //ConstTest.Pi=30;//Const yapısı Sadece okuma işlemi yapar
            Console.WriteLine(ConstTest.Pi);//Sabit değerler sınıf adı ile çağrılır
            Console.WriteLine(readOnlyTest.Deger);

        }
    }
}
