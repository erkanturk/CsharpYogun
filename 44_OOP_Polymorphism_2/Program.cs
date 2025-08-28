namespace _44_OOP_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HesapIslemleri hesapIslemleri = new HesapIslemleri();
            hesapIslemleri.ParaGonder(300);
            hesapIslemleri=new Havale();
            hesapIslemleri.ParaGonder(400);

            hesapIslemleri=new Eft();
            hesapIslemleri.ParaGonder(500);

            hesapIslemleri=new Swift();
            hesapIslemleri.ParaGonder(550);
        }
    }
}
