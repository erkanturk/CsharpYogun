namespace _46_OOP_Abstraction_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon = new Telefon();
            telefon.AlisFiyati=25000;
            telefon.KarYuzdesi=1.20;
            Console.WriteLine(telefon.FiyatHesapla());

            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.EkMasraf=1000;
            bilgisayar.AlisFiyati=10000;
            bilgisayar.KarYuzdesi=1.05;
            Console.WriteLine(bilgisayar.FiyatHesapla());
        }
    }
    abstract class Elektronik//Base class
    {
        public  double AlisFiyati { get; set; }
        public  double KarYuzdesi { get; set; }

        //public abstract double FiyatHesapla()//Soyut bir işlem yaptığım için hata verir
        //{
        //    return AlisFiyati+(AlisFiyati*KarYuzdesi);
        //}
        public abstract double FiyatHesapla();

    }
    class Telefon : Elektronik
    {
        public override double FiyatHesapla()
        {
            return AlisFiyati + (AlisFiyati*KarYuzdesi);
        }
    }
    class Bilgisayar : Elektronik
    {
        public double EkMasraf { get; set; }


        public override double FiyatHesapla()
        {
            return AlisFiyati + (AlisFiyati*KarYuzdesi)+EkMasraf;
        }
    }
    class Tablet : Elektronik
    {
        public double Kilif {  get; set; }
        public override double FiyatHesapla()
        {
            return Kilif+ AlisFiyati + (AlisFiyati*KarYuzdesi);
        }
    }
}
