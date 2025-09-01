namespace _46_OOP_Abstraction_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çalışan diye bir sınıfımız olsun
            //abstract class Ad Soyad
            //işe giriş tarihi olsun
            //bilgi yaz diye
            //Abstract method olsun 
            //Bu yapıyı Ik Muhasebe
            //gibi yapılar kullanacak ve her biri
            //kendi özelliklerini
            //bilgi yaz yapısında gösterecek

            Muh muh = new Muh("Erkan", "Türk", 30);
            muh.Bilgi();
            Ik ik = new Ik("Erkan", "Türk", "Yazılım", "8 yıldır sql ve 6 yıldır .net yazıyorum");
            ik.Bilgi();
            Calisan calisan = new Ik("Erkan", "Türk", "Yazılım", "8 yıldır sql ve 6 yıldır .net yazıyorum");
            calisan.Bilgi();
        }
    }
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DateTime { get; set; }

        public Calisan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            DateTime = DateTime.Now;

        }
        public abstract void Bilgi();
    }
    class Ik : Calisan
    {

        public string Bolum { get; set; }
        public string Deneyim { get; set; }

        public Ik(string ad, string soyad, string bolum, string deneyim) : base(ad, soyad)
        {
            Bolum = bolum;
            Deneyim = deneyim;
        }


        public override void Bilgi()
        {
            Console.WriteLine(Ad+" "+Soyad+" "+Bolum+" "+Deneyim);
        }
    }
    class Muh : Calisan
    {
        public int FaturaAdet { get; set; }

        public Muh(string ad, string soyad, int faturaAdet) : base(ad, soyad)
        {
            FaturaAdet=faturaAdet;
        }

        public override void Bilgi()
        {
            Console.WriteLine(Ad+" "+Soyad+" "+FaturaAdet);
        }
    }
    //class Muh : Ik
    //{
    //    public Muh(string ad, string soyad, string bolum, string deneyim) : base(ad, soyad, bolum, deneyim)
    //    {
    //    }
    //    public override void Bilgi()
    //    {
    //        base.Bilgi();
    //    }
    //}
}
