namespace _43_OOP_Partial_Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad="Erkan";
            ogrenci.Soyad="Türk";
            ogrenci.Tc="123";
            ogrenci.OgrenciNO=123;
            ogrenci.DerslikNo="123";
            ogrenci.Bolum="Yazılım";

            ogrenci.Bilgi2();
        }
    }
}
