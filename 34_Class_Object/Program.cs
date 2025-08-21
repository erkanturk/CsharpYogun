namespace _34_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            /* Access Modifiers (Erişim belirleyiciler)
             * ****Private (Özel)*****
             * Private=>Yalnızca tanımlandığı alan içerisinde erişim sağlanabilir.
             * Kalıtım yolu dahi olsa kalıtım alan sınıf private değere erişemez.
             * Eğer bir yapıya erişim belirleyici vermezsek varsayılan olarak private olur
             * ****Public****
             * Public=> Hiçbir erişim kısıtlaması yoktur proje özelindeki her yapı bu yapıya erişim
             * sağlayabilir.
             * ****internal****
             * Internal=>Aynı proje içerisinde yer alan yapılar erişebilir.
             * Fakat farklı bir projeden erişim sağlamak istediğimizde bu erişim gerçekleştirilemez.
             * ****Protected****
             * Protected=>Tanımlandığı tip ve o tipden kalıtılmış(miras alınmış) tiplerin içerisinden
             * erişilebilinir. Tanımladığı sınıfta veya o sınıftan türetilmiş sınıflardan erişilebilir.
             * ****Sealed****
             * Sealed=> Mühürlü sınıf olarak geçer bu yapı ile işaretlenmiş bir sınıf
             * miras almaya kapalıdır.

             
             */
            #endregion

            Urun urun = new Urun();
            urun.Aciklama="test";
            urun.Fiyat=1200;
            urun.Degerlendirme=5;
            urun.Resim="1.jpg";
            urun.YorumSayisi=1000;
            urun.Id=1;
            urun.Unvan="Gömlek";

            //Sol taraftaki alt + shift yön tuşları ile birden fazla satır seçebiliriz.
            Urun urun2 = new Urun();
            urun2.Aciklama="test2";
            urun2.Fiyat=2200;
            urun2.Degerlendirme=4;
            urun2.Resim="1.jpg";
            urun2.YorumSayisi=2000;
            urun2.Id=2;
            urun2.Unvan="Ayakkabı";

            Urun urun3 = new Urun()
            {
                Aciklama= "test3",
                Fiyat=3300,
                Degerlendirme=5,
                Resim="4.jpg",
                Id=3,
                Unvan="klavye"
            };
            List<Urun> urunListesi = new List<Urun>();
            urunListesi.Add(urun);
            urunListesi.Add(urun2);
            urunListesi.Add(urun3);

            foreach (var item in urunListesi)
            {
                Console.WriteLine(item.Id+" "+item.Aciklama+" "+item.Unvan+" "+item.Resim+" "+item.Degerlendirme+" "+item.Fiyat);
            }

            List<Buzdolabi> buzdolabis = new List<Buzdolabi>()
            {
                new Buzdolabi(){Id=1,Marka="Arçelik",Model="B150",Fiyat=14000,Enerji="E",Renk="Gri"},
                new Buzdolabi(){Id=1,Marka="Bosh",Model="C150",Fiyat=24000,Enerji="B",Renk="Beyaz"},
                new Buzdolabi(){Id=1,Marka="Profilo",Model="A150",Fiyat=34000,Enerji="A",Renk="Gri"}
            };
            foreach (var item in buzdolabis)
            {
                Console.WriteLine(item.Id+"\n"+item.Model+"\n"+item.Marka+"\n"+item.Renk+"\n"+item.Enerji+"\n"+item.Fiyat);
            }
        }
    }
}
