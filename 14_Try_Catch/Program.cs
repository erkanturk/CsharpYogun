namespace _14_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Try_Catch: Fırlatılan Exception'ları yakalayarak programın akışını durdurmadan hata durumunda ne yapılması 
             * gerektiğini tanımlar
            */
            //try//kod yapımız try tarafında tanımlanır bu alanda çalışır eğer bir hata alırsa catch kısmına aktarır.
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi/0);
            //}
            //catch (FormatException ex)//format hataları için kullanılır
            //{
            //    Console.WriteLine("Sayı rakamlardan oluşur. "+ex.Message);
            //}
            //catch (DivideByZeroException ex)//sıfıra bölünme hatasını yakalar.
            //{
            //    Console.WriteLine("Sayı 0 a bölünemez "+ex.Message);
            //}
            //catch (Exception ex)//geriye kalan tüm hataları yakalar
            //{
            //    Console.WriteLine(ex);
            //    Console.WriteLine("Genel hatalar: "+ex.Message);
            //}

            //try//kod yapımız try tarafında tanımlanır bu alanda çalışır eğer bir hata alırsa catch kısmına aktarır.
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi/0);
            //}

            //catch (Exception ex)//geriye kalan tüm hataları yakalar
            //{
            //    //Console.WriteLine(ex);
            //    Console.WriteLine("Genel hatalar: "+ex.Message);
            //}


            #region try catch finally
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi/0);
                Console.WriteLine("Merhaba");//hata durumunda bu alan hiç bir zaman çalışmaz
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // throw;//hata fırlatma 
            }
            finally
            {
                Console.WriteLine("Her türlü çalışırım ");//Her türlü çalışacak kısım eğer hata varsa yine çalışır olmasa yine çalışır.
            }           
            #endregion
        }
    }
}
