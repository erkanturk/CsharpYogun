namespace _47_OOP_Interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hizmetli hizmetli = new Hizmetli();
            hizmetli.Ad="Erkan";
            hizmetli.Soyad="Türk";
            hizmetli.Maas=4000;
            hizmetli.SozlesmeTarihi=DateTime.Now;
            hizmetli.MaasHesapla();
        }
    }
    class Insan//Nesne oluşturmayacağımız yapıları Abstract olarak işaretleyip bu alanın base class olduğunu belirtiriz
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    interface ICalisan//bir arabirim sınıflara birden fazla yapıyı kullanmaya zorlar
    {
        public int SgkNo { get; set; }
        public int Maas { get; set; }
        public int MaasHesapla();
    }
    interface IOzelIsci : ICalisan//Ozel işci yapısı burada çalışanıda implemete ettiği için
                                  //artık hem çalışan hemde özel çalışanı implemete etmeye zorlayacaktır
    {
        public DateTime SozlesmeTarihi { get; set; }
    }
    class Ogrenci : Insan
    {
        public int OkulNo { get; set; }
    }
    class Mudur : Insan, ICalisan
    {
        public int SgkNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int OgretmenSayi { get; set; }

        public int MaasHesapla()
        {
            throw new NotImplementedException();
        }
    }
    class Ogretmen : Insan, ICalisan
    {
        public string Brans { get; set; }
        public int SgkNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int MaasHesapla()
        {
            throw new NotImplementedException();
        }
    }
    class Hizmetli : Insan, IOzelIsci
    {
        public DateTime SozlesmeTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SgkNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int MaasHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
