namespace _07_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random sınıfı Ram bellekten bize rasgele sayılar üreten bir yapıdır genelde oyunlar simülasyonlar
            // ve test senaryolarında kullanılır.
            Random random = new Random();// new Random() Örneklem instance nesne 
            int sayi = random.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı üretir. 100 dahil değildir.

            Console.WriteLine(sayi);
        }
    }
}
