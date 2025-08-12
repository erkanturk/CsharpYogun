namespace _15_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays - Diziler
            //Değişkenlerin aksine Index adı verilen numaralandırma yöntemi ile tutulan birden fazla değer tutabilen
            //Koleksiyon yapılarıdır.
            //*** Index numaraları 0 dan başlar ve 1'er 1'er artar.
            // Arrays kendilerina ait metodlara sahiptirler.
            // Array [] ile tanımlanır
            // tek veri tipinde uzunluk kadar eleman tutar
            //veritipi[] değişken adı = new veritipi[uzunluk]

            //Boş array tanımlama 
            string[] isimler = new string[5];
            isimler[0]="Erkan";//1 eleman
            isimler[1]="Hikmet";//2. eleman
            isimler[2]="Murat";//3.eleman
            isimler[3]="Derya";//4.eleman
            isimler[4]="Reyhan";//5.eleman
            //uzunluğunun -1 i benim index sayımdır.
            //Console.WriteLine(isimler);//bu yapı bana sadece string bir array olduğunu iletir
            //Console.WriteLine(isimler[0]);//yazdırmak istediğimiz index değerini veriyoruz. 0. index 1. eleman
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //Dolu array sabit değerler olarak elemanlarını belirtmemiz gerekiyor.
            string[] adlar = { "Samet", "Halil", "Onur", "Altan", "Yağmur", "Birsu", "Nazlı", "Arhan", "Tuğba", "Mert" };
            //Console.WriteLine(adlar[3]);//index değerine göre yazdırır.
            for (int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine(adlar[i]);
            }
            Console.WriteLine("********************");
            int index = 0;
            while (index < adlar.Length)
            {
                Console.WriteLine(adlar[index]);
                index++;
            }

        }
    }
}
