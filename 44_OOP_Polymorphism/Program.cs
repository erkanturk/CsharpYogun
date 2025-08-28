namespace _44_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphism(Çok biçimcilik)
            /*
         POLYMORPHISM NEDİR? 

         Çokbiçimlilik (Polymorphism) bir nesnenin farklı amaçlar için de kullanılabileceği 
        anlamına gelir ve statik, dinamik olmak üzere ikiye ayrılır.

            * Statik çokbiçimlilik; metot ve operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
            * Dinamik çokbiçimlilik; özet sınıflardan miras alma yoluyla işlemlerin gerçekleştirilmesi 
            * işlemine verilen isimdir.

        Statik çokbiçimlilik türünden, metotların aşırı yüklenmesine yönelik bir çalışma yapacağız.

        Dinamik çokbiçimlilik türünden, metodu override etmeliyiz.

        VIRTUAL() METODU

        *Temel sınıfa ait bir metodun bazen türemiş sınıfta farklı bir şekilde kullanılması gerekebilir.
        *Bu durumda temel sınıfın söz konusu metodu türemiş sınıfın değiştirip kullanabileceği 
        *yönünde izin vermesi gerekir. Bu izin, metodun temel sınıfta “virtual” olarak tanımlanması 
        *sonucu verilmektedir. Diğer bir ifadeyle temel sınıfta “virtual” olarak tanımlanmış bir metodun
        *türemiş sınıfta yeniden yazılabileceği belirtilmiş olunuyor.


        METODU OVERRIDE ETMEK, OVERRIDE NEDİR?METOTUN EZİLMESİ

        *Temel sınıfta “virtual” tanımlanmış bir metodun türemiş sınıfta yeniden 
        *yazılması için (geçersiz kılma) “override” sözcüğü kullanılır. 
         *Temel sınıfta “virtual” tanımlanmamış ya da “static” tanımlanmış olan 
         *üyeler (metot, özellik, dizinleyici ya da olay) türemiş sınıfta yeniden yazılamaz (Geçersiz kılınamaz.).

        Ayrıca temel sınıfta “virtual”, “abstract” ya da “override” olarak tanımlanmış
        metotlar türemiş sınıfta geçersiz kılınabilir.
        Bir diğer önemli nokta da “override” metotlar “new”, “static” ya da “virtual”
        sözcükleri ile tanımlanamaz.

        Son olarak “virtual” metodun erişim belirteci “override” sırasında değiştirilemez.
        Yani temel sınıfta metot “public” ise türemiş sınıfta da “public”, “protected” ise “protected” kalmalıdır.
        */

            #endregion

            //Ogretmen ogretmen = new Ogretmen();
            //ogretmen.Kaydet();
            LiseOgrenci liseOgrenci = new LiseOgrenci();
            liseOgrenci.Kaydet();

        }

    }
    class Ogretmen : Insan
    {
        public string Brans { get; set; }
        public override void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Branş");
            Brans=Console.ReadLine();
        }
    }

    class LiseOgrenci : Ogrenci
    {
        public override void Kaydet()
        {
            base.Kaydet();
        }
    }

    class Ogrenci : Insan
    {
        public int Numara { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }

        public void NotAl()
        {
            Console.WriteLine("Vize:");
            Vize=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final:");
            Final=Convert.ToInt32(Console.ReadLine());

        }
        public void NotAl(int vize, int final)
        {
            Vize=vize;
            Final=final;
        }
        public override void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Numara:");
            Numara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vize:");
            Vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final:");
            Final = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public virtual void Kaydet()
        {
            Console.WriteLine("Ad:");
            Ad=Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad=Console.ReadLine();
            Console.WriteLine("Yaş:");
            Yas=Convert.ToInt32(Console.ReadLine());
        }
    }
}
