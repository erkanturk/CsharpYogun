namespace _18_String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Hazır Methodlar
            string metin = "C# Dersleri";
            string[] adSoyad = { "Erkan", "Türk" };
            string ad = "Hikmet";
            string soyad = "Yıldız";
            string text = "     String Metinler     ";
            string adlar = "Erkan Tahsin Onur Altan";

            Console.WriteLine($"String Uzunluğu: {metin.Length}");
            Console.WriteLine($"String Büyütme: {metin.ToUpper()}");
            Console.WriteLine($"String Küçültme: {metin.ToLower()}");
            bool buldum = metin.Contains("");//Değer var ise true false olarak cevap verir.
            Console.WriteLine($"Var mı ? {buldum}");
            string degistirilmisMetin = metin.Replace("C#", "Yazılım");
            Console.WriteLine(degistirilmisMetin);
            string birlestirilmisDizi = string.Join(" ", adSoyad);
            Console.WriteLine(birlestirilmisDizi);
            string birlestirilmisMetin = string.Concat(ad, " ", soyad);
            Console.WriteLine(birlestirilmisMetin);
            Console.WriteLine("Boşluk temizleme: "+text.Trim());
            string[] adDizisi = adlar.Split(' ');
            
            foreach (var item in adDizisi)
            {
                Console.WriteLine(item);
            }
            string parcalanmisMetin = metin.Substring(0, 2);//başlangıç indexi ve uzunluk gerekmektedir.
            Console.WriteLine(parcalanmisMetin);
        }
    }
}
