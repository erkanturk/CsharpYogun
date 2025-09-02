namespace _47_OOP_Interface_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suv suv = new Suv();
            suv.YakitTipi="Hibrit";
            suv.Hiz=250;
            suv.beygir=1000;
            suv.Kapasite=4;
            suv.KapiSayisi=4;

            Ucak ucak = new Ucak();
            ucak.YakitTipi="Jet yakıtı";
            ucak.Hiz=380;
            ucak.Kapasite=50;
            ucak.EkonomiMi=false;

        }
    }
    public abstract class Tasit
    {
        public abstract int Hiz { get; set; }
        public abstract int Kapasite { get; set; }

    }
    public interface Araba
    {
        public int KapiSayisi { get; set; }
        public int beygir { get; set; }
    }
    public interface Yakit 
    {
       public string YakitTipi { get; set; }
    }
    public class Sport : Tasit, Yakit, Araba
    {
        public override int Hiz { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Kapasite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string YakitTipi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int KapiSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int beygir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Suv : Tasit, Yakit, Araba
    {
        public override int Hiz { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Kapasite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int KapiSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int beygir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string YakitTipi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class Ucak : Tasit, Yakit
    {
        public bool EkonomiMi { get; set; }
        public override int Hiz { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Kapasite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string YakitTipi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
