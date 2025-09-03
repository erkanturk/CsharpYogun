namespace _48_GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Generic Mimari,
             * Aynı tasarımda farklı objelerin üretilmesine imkan sağlayan 
             * C# mimarisi için ÇOK önemli bir yapıdır.
             * Generic mimari olmasaydı kod yazmak zorlaşırdı ve tekrar eden kodlar artardı
             * tip güvenliği çok azalırdı ileride göreceğimiz Linq yapısı diye bir sorgulama yapısı olmazdı
             * 


             */
            TestSinifi<int> testSinifi = new TestSinifi<int>();
            testSinifi.NonGenerinField=10;
            testSinifi.GenericField=10;
            TestSinifi<string> testSinifi2 = new TestSinifi<string>();
            testSinifi2.GenericField="10";//burası generic bir yapı olduğu için T yapısına belirtiğimiz değer tanımlarken 
            //istediğimiz veri tipini verebiliriz.
            //testSinifi2.NonGenerinField="10";//bu alan generic olmadığı için sadece int değer alacaktır.

            UrunSinifi<double> urunSinifi = new UrunSinifi<double>(1000, 2000);
            urunSinifi.Fiyat=1500;
            urunSinifi.Kdv=1.2;

            UrunSinifi<int> urunSinifi2 = new UrunSinifi<int>(100, 200);
            urunSinifi.Fiyat=11;
            urunSinifi.Kdv=11;
            UrunSinifi<char> urunSinifi3 = new UrunSinifi<char>('A', 'b');


        }
    }
}
