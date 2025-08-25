namespace _35_Class_Object_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Static sınıflar sadece static yapıları barındırır 
             * static olarak tanımlanan yapılarım methodları da static olmalıdır
             * Program çalışır çalışmaz static yapılar ayağa kalkar Yani arka planda 
             * constructor yapısı çalışır.
             */
            List<BuzDolabi> buzDolabis = new List<BuzDolabi>();
            //BuzDolabi buzDolabi = new BuzDolabi();
            //buzDolabi.Kaydet();//nonstatic bir yapı olduğu için bir nesne üzerinden 
            //BuzDolabi.Ekle();//Static Yapılardan nesne oluşturulamaz. Sınıf üzerinden çağırma
            ////işlemleri yapabiliriz.
            ////Console.WriteLine();
            ////Random random = new Random();
            //BuzDolabi.Kaydet();//Nonstatic yapıda nesne üzerinden erişmemiz gerekmektedir.
            //buzDolabi.Ekle();//static yapıda sınıf üzerinden gitmem gerekmektedir
            //buzDolabis.Add(BuzDolabi.Ekle());

            ////var buzdolabi1 = BuzDolabi.Ekle();
            //// buzDolabis.Add(buzdolabi1);
            //BuzDolabi.Ekle(buzDolabis);
            //foreach (var item in buzDolabis)
            //{
            //    Console.WriteLine(item.Marka+" "+item.Model+" "+item.Enerji+" "+item.Fiyat);
            //}

            SeedClass.Ekle();
           
            BuzDolabi b = new BuzDolabi();
            //b.Kaydet();
            //buzDolabis.Add(b);
            b.Kaydet(buzDolabis);
            
            foreach (var item in buzDolabis)
            {
                Console.WriteLine(item.Marka+" "+item.Model+" "+item.Enerji+" "+item.Fiyat);
            }


        }
    }
}
