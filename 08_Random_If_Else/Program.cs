namespace _08_Random_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Random random = new Random();
            int sansliSayi = random.Next(1, 30);//4
            Basla:
            Console.WriteLine("Lütfen Şanslı Sayınızı Giriniz");
            int kullaniciSayi = Convert.ToInt32(Console.ReadLine());
            if (kullaniciSayi==sansliSayi)
            {
                Console.WriteLine("Tebrikler şanslısınız Hocanızıda alın milli piyango oynayın.");
            }
            else
            {
                Console.WriteLine("Lütfen Tekrar Deneyin");
                goto Basla;
            }
          
            Console.WriteLine("test");

        }
    }
}
