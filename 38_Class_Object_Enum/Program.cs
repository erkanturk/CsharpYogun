namespace _38_Class_Object_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //KitapKategori adında  enum oluşturarak içerisine,
            //BilimKurgu=0, DunyaKlasikleri=1, Psikoloji=2 olmak üzere 3 kategori ekleyelim.
            //Kullanıcıdan string olarak kategori girmesini isteyelim,
            //girilen değeri KitapKategori enum'ına çevirerek switch case ile kontrol edip aşağıda belirtilen şekilde mesajı yazdıran programı yazalım.
            //BilimKurgu ise: "Bilim Kurgu kategorisindeki kitaplar A reyonundadır."
            //DunyaKlasikleri ise:  "Dünya Klasikleri kategorisindeki kitaplar B reyonundadır."
            //Psikoloji ise:  "Psikoloji kategorisindeki kitaplar C reyonundadır."
            #endregion
            //Enum yapısı
            /* Enumlar yani sabitler olarak adlandırılır bu veri tipi hem sayısal hem metinsel olarak bize değer dönderir
             * sabit veri yapılarında genelde enum yapısı kullanılır.
             * Bir veriyi veri tabanında sayısal olarak tutarken biz programda bu veriyi metinsel olarak kullanmak isteyebiliriz
             * Bu tür durumlarda enum yapısı kullanılır.
             * Enumlar varsayılan olarak int veri tipindedir ve 0 dan başlar 1,1 artarak gider 
             * Eğer istenirse enum yapısına başlangıç değeri verilebilir.
             * Enum yapısında aynı isimde eleman olamaz ve aynı sayısal değere sahip eleman olamaz.
             * ilk verilen değeri diğer elemanlar takip eder.
            
            */
            #region Örnek 1 
            //Araba araba = new Araba();
            //araba.Marka=Markalar.Toyota;
            //araba.Model="Supra";
            //araba.Renk=Renkler.Turuncu;
            //araba.Vites=Vitesler.Manuel;

            //araba.Bilgi();
            //Console.WriteLine(Markalar.BMW);//Marka ismini yazdırır
            //Markalar s2 = Markalar.Honda;
            //Console.WriteLine((int)s2);//Marka numarasını yazdırır

            //string[] markalar = Enum.GetNames(typeof(Markalar));
            ////int[] markalar2 = Enum.GetValues(typeof(Markalar));
            //int[] markalar2 = (int[])Enum.GetValues(typeof(Markalar));
            //foreach (var item in markalar2)
            //{
            //    Console.WriteLine(item);
            //}
            //bool sonuc = Enum.IsDefined(typeof(Markalar), 3);
            //bool sonuc2 = Enum.IsDefined(typeof(Markalar), "Bmw");
            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);

            //for (int i = 0; i < 15; i++)
            //{
            //    string backColor = i.ToString();
            //    string foreColor = i.ToString();

            //    Console.BackgroundColor=(ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            //    Console.ForegroundColor=(ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
            //    Console.Clear();
            //    Thread.Sleep(100);
            //    if (i==14)
            //    {
            //        i=0;
            //        continue;
            //    }
            ////}
            //Console.WriteLine("BackgroundColor giriniz");
            //string backColor = Console.ReadLine();
            //Console.WriteLine("ForegroundColor giriniz");
            //string foreColor = Console.ReadLine();
            ////Console tarafında gönderdiğimiz değer enum yapısında bize renk olarak döner
            //Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            //Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
            //Console.WriteLine("Renk ayarlandır");
            #endregion

            Console.WriteLine("Kategori seçiniz");
            string kategori = Console.ReadLine();
            KitapKategori kitapKategori = (KitapKategori)Enum.Parse(typeof(KitapKategori), kategori);
            switch (kitapKategori)
            {
                case KitapKategori.BilimKurgu:
                    Console.WriteLine("Bilim Kurgu kategorisindeki kitaplar A reyonundadır.");
                    break;
                case KitapKategori.DunyaKlasikleri:
                    Console.WriteLine("Dünya Klasikleri kategorisindeki kitaplar B reyonundadır.");
                    break;
                case KitapKategori.Psikoloji:
                    Console.WriteLine("Psikoloji kategorisindeki kitaplar C reyonundadır.");
                    break;
                case KitapKategori.Aksiyon:
                    Console.WriteLine("Aksiyon kategorisindeki kitaplar D reyonundadır.");
                    break;
                case KitapKategori.Macera:
                    Console.WriteLine("Macera kategorisindeki kitaplar E reyonundadır.");
                    break;
                default: Console.WriteLine("Hatalı seçim"); break;
            }
        }
    }
    enum Markalar { Ford =4, Toyota, Honda, BMW, Audi }
    enum Renkler { Kırmızı = 1, Mavi, Yeşil, Sarı, Turuncu }
    enum Vitesler : byte { Manuel = 2, Otomatik, YarıOtomatik }
    class Araba
    {
        public string Model;
        public Markalar Marka;
        public Renkler Renk;
        public Vitesler Vites;

        public void Bilgi()
        {
            Console.WriteLine($"Model:{Model} Marka:{Marka} Renk:{Renk} Vites:{Vites}");
        }
    }
}
