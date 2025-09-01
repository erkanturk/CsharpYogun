namespace _42_OOP_Inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<InsanKaynaklari> IkListesi = new List<InsanKaynaklari>()
           {
               new InsanKaynaklari(){Id=1,Ad="Erkan",Soyad="Türk",TcNo="111",PersonelSayisi=5 },
               new InsanKaynaklari(){Id=2,Ad="Altan Emre",Soyad="Demirci",TcNo="222",PersonelSayisi=3 },
               new InsanKaynaklari(){Id=3,Ad="Tahsin",Soyad="Canpolat",TcNo="4444",PersonelSayisi=5 },
               new InsanKaynaklari(){Id=4,Ad="Onur",Soyad="Yağız",TcNo="555",PersonelSayisi=5 }
           };
            InsanKaynaklari isk = new InsanKaynaklari();
            isk.Kaydet();

            while (true)
            {
                Console.WriteLine("Lütfen bir birim seçiniz:\n1-İk\n2-IT\n3-Muh");
                string secim = Console.ReadLine();
                if (secim=="1")
                {
                    Console.WriteLine("Yapmak istediğiniz İşlem \n1-Ekle\n2-Sil\n3-Guncelle\n4-Listele");
                    string islem = Console.ReadLine();
                    if (islem=="1")
                    {
                        InsanKaynaklari ik = new InsanKaynaklari();
                        ik.Kaydet();
                        IkListesi.Add(ik);

                    }
                    else if (islem=="2")
                    {
                        InsanKaynaklari.Sil(IkListesi);
                    }
                    else if (islem=="3")
                    {
                        InsanKaynaklari.Guncelle(IkListesi);
                    }
                    else if (islem=="4")
                    {
                        InsanKaynaklari.Listele(IkListesi);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı tuşlama");
                    }
                }

            }
        }
    }
}
