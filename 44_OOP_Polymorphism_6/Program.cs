namespace _44_OOP_Polymorphism_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ödev
            /* 
                Tekstil:Ad,Fiyat,KumasTuru,Beden,UreticiFirma = KDVUygular(%20)
                CepTelefonu:Ad,Fiyat,Özellik,Marka = KDVUygular(%120)
                Ekmek:Tür,Fiyat,Gramaj = KDVUygular(%10)

            Nesne özelliklerini constructor methodu ile alın.
            Sepet: Alınan ürünleri bir listeye kaydetsin toplam tutarı söylesin
            
            */
            
            Console.WriteLine("Urun adı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Fiyat giriniz");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Ekmek ekmek = new Ekmek(ad, fiyat, "tambuday", 100);
            CepTelefonu cepTelefonu = new CepTelefonu("Samsung", 30000, "24Mp Kamera", "A150");
           

            Sepet sepet = new Sepet();
            sepet.Ekle(ekmek);
            sepet.Ekle(cepTelefonu);
            Console.WriteLine(sepet.ToplamTutar());
            Console.WriteLine(ekmek.Ad+" "+ekmek.EkmekTuru+" "+ekmek.Fiyat+" "+fiyat);
            Console.WriteLine(cepTelefonu.Ad+" "+cepTelefonu.Marka+" "+cepTelefonu.Fiyat);
        }
    }
    class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;

        }
        public virtual double KdvUygula()
        {
            return Fiyat *1.2;
        }
    }
    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public string Beden { get; set; }
        public string UreticiFirma { get; set; }

        //Base class taki ctor yapısı bizden parametre bekliyor ise child sınıf yapısı bu değerleri vermek zorundadır.
        public Tekstil(string ad, double fiyat, string kumasTuru, string beden, string ureticiFirma) : base(ad, fiyat)
        {
            KumasTuru=kumasTuru;
            Beden=beden;
            UreticiFirma=ureticiFirma;
        }
    }
    class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        public int Gramaj { get; set; }
        public Ekmek(string ad, double fiyat, string ekmekTuru, int gramaj) : base(ad, fiyat)
        {
            EkmekTuru=ekmekTuru;
            Gramaj=gramaj;
        }
        public override double KdvUygula()
        {
            return Fiyat *1.1;
        }
    }
    class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ad, double fiyat, string ozellikler, string marka) : base(ad, fiyat)
        {
            Ozellikler=ozellikler;
            Marka=marka;
        }
        public override double KdvUygula()
        {
            return Fiyat * 2.2;
        }
    }
    class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public double ToplamTutar()
        {
            double toplamFiyat = 0;
            foreach (Urun urun in urunler)
            {
                toplamFiyat+=urun.Fiyat;
              
            }
            return toplamFiyat;
        }
        public void Ekle(Urun urun)
        {
            urun.Fiyat=urun.KdvUygula();
            urunler.Add(urun);
        }
    }
}
