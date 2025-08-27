namespace _42_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kalıtım (Inheritance)
             * Ortak özelliklere sahip classların tek bir class üzerinden miras alma yöntemi ile
             * ortak olan özellikleri yazılmadan çekmesine ve sadce kendisine özel olan özellikleri tanımlamasını sağlar

             
            */
            Ik ik = new Ik();
            ik.Ad="Erkan";
            ik.Soyad="Türk";
            ik.Adres="İstanbul";
            ik.Tc="12345678901";
            ik.PersonelSayisi=150;
            ik.PersonelBilgi();
            Muh muh = new Muh();
            muh.Ad="Ahmet";
            muh.Soyad="Yılmaz";
            muh.Adres="Ankara";
            muh.Tc="12345678902";
            muh.Maas=15000;
            muh.PersonelBilgi();
            //muh.PersonelBilgi();//Base classdaki methodu kullanır kendi maaş bilgisini gösteremez  bu yapı child classtır
            //child classlar base classa miras veremez base classlar child classlara miras verebilir
            

        }
    }
    class Personel
    {
        public string Tc { get; set; }
        // public string Ad { get; }//Sadece içindeki değeri gösterir düzenlenemez property
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public int CocukSayisi { get; set; }

        public void PersonelBilgi()
        {
            Console.WriteLine($"Ad:{Ad} Soyad:{Soyad} Adres:{Adres} Çocuk Sayısı:{CocukSayisi}");
        }

    }
    class Ik : Personel//: kalıtım demektir bu yapıyı gördüğünüzde miras alma işlemi yapacağını belirtiriz.
    {
        public int PersonelSayisi { get; set; }

        public new void PersonelBilgi()//Base classdaki methodu ezerek kendi methodumuzu kullanırız.
        {
            Console.WriteLine($"Ad:{Ad} Soyad:{Soyad} Adres:{Adres} Çocuk Sayısı:{CocukSayisi} Personel Sayısı:{PersonelSayisi}");
        }
    }
    class Paz : Personel
    {
        public int MusteriSayisi { get; set; }

    }
    class Muh : Personel
    {
        public decimal Maas { get; set; }
    }
  
}
