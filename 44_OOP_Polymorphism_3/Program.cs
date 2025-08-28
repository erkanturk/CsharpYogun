namespace _44_OOP_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            insan.HaketEt();

            Yilan yilan = new Yilan();
            yilan.HaketEt();

            Kus kus = new Kus();
            kus.HaketEt();

            Balik balik = new Balik();
            balik.HaketEt();
        }
    }
}
