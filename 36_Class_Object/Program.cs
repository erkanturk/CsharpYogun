namespace _36_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Okul> okuls = new List<Okul>();
            Okul okul = new Okul();
            okul.OgrenciNo=537;
            okul.Ad="Erkan";
            okul.Soyad="Türk";
            okul.Yas=31;
            okuls.Add(okul);
            Okul okul2 = new Okul();
            okul2.OgrenciNo=347;
            okul2.Ad="Yavuz";
            okul2.Soyad="Acar";
            okul2.Yas=25;
            okuls.Add(okul2);

            foreach (var ogrenci in okuls)
            {
                Console.WriteLine(ogrenci.OgrenciNo+" "+ogrenci.Ad+" "+ogrenci.Soyad+" "+ogrenci.Yas);
            }
          

        }
    }
}
