namespace _41_03_Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vatandas vatandas = new Vatandas();

            //Console.WriteLine("Adınızı  ve soyadınızı giriniz");
            //vatandas._AdSoyad = Console.ReadLine();
            //Console.WriteLine("Tc kimlik numaranız");
            //vatandas._TcNo = long.Parse(Console.ReadLine());
            Islem islem = new Islem();
            Console.WriteLine("Birinci sayi");
            islem.sayi = double.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayi");
            islem._Sayi2 = double.Parse(Console.ReadLine());



        }
    }
    class Vatandas
    {
        private string AdSoyad;
        private long TcNo;

        public string _AdSoyad
        {
            get { return AdSoyad; }

            set
            {
                if (value.Length>=0&&value.StartsWith("A"))
                {
                    AdSoyad=value;
                    Console.WriteLine(AdSoyad);
                }
                else
                {
                    Console.WriteLine("Adınız A ile başlamalıdır");
                }
            }
        }
        public long _TcNo
        {
            get { return TcNo; }
            set
            {
                if (value.ToString().Length==11)
                {
                    TcNo=value;
                    Console.WriteLine(TcNo);
                }
                else
                {
                    Console.WriteLine("Tc no 11 haneli olmalıdır");
                }
            }
        }
    }

    class Islem
    {
        public double sayi;
        private double sayi2 ;

        public double _Sayi2
        {
            get { return sayi2; }

            set
            {
                if (value>0&&sayi>value)
                {
                    sayi2=value;
                    Console.WriteLine($"Sonuc: {sayi/=sayi2}");

                }
                else if (value==0)
                {
                    Console.WriteLine("Sayı sıfıra bölünemez");
                }
                else
                {
                    Console.WriteLine("ikinci değer birinci değerden büyük olamaz");
                }
            }

        }
    }
}
