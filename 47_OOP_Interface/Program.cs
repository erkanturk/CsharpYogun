namespace _47_OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kus kus = new Kus();
            kus.HareketEt();
            kus.Yuru();
            kus.Yuz();
            kus.Uc();

            Balik balik = new Balik();
            balik.HareketEt();
            balik.Yuz();
            //balik.Yuru(); balık bu eylemi gerçekleştiremez.

            Insan insan = new Insan();
            insan.HareketEt();
            insan.Yuz();
            insan.Yuru();

        }
    }
}
