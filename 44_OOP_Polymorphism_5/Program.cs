namespace _44_OOP_Polymorphism_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suv suv = new Suv();
            suv.OzellikYaz();
            Console.WriteLine("************************");
            Console.WriteLine($"{suv.Marka} {suv.Model} {suv.Ceker} {suv.Renk} {suv.YakitTipi} {suv.Vites} {suv.KapiSayisi}");
            Sport sport = new Sport();
            sport.OzellikYaz();
            Console.WriteLine($"{sport.Marka} {sport.Model} {sport.BeygirGucu} {sport.Renk} {sport.YakitTipi} {sport.Vites} {sport.KapiSayisi}");
        }
    }
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KapiSayisi { get; set; }
        public string Renk { get; set; }
        public string YakitTipi { get; set; }
        public string Vites { get; set; }

        public virtual void OzellikYaz()
        {
            Console.WriteLine("Marka:");
            Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            Model=Console.ReadLine();
            Console.WriteLine("KapiSayisi:");
            KapiSayisi=Console.ReadLine();
            Console.WriteLine("Renk:");
            Renk=Console.ReadLine();
            Console.WriteLine("Yakit Tipi:");
            YakitTipi=Console.ReadLine();
            Console.WriteLine("Vites:");
            Vites=Console.ReadLine();
        }
    }
    class Suv : Araba
    {
        public string Ceker { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine("Çeker tipi:");
            Ceker=Console.ReadLine();
        }
    }
    class Sport : Araba
    {
        public string BeygirGucu { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine("Kaç beygir ?");
            BeygirGucu=Console.ReadLine();
        }
    }
}
