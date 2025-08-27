namespace _41_KapsullemeOdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BankaAccount account = new BankaAccount();
            while (true)
            {
                Console.WriteLine("Muhasebeye Hoşgeldiniz");
                Console.WriteLine("Muhasebe işlemleri için 1 e basınız Çıkış için Q ya basınız");
                string secim = Console.ReadLine().ToUpper();
                if (secim=="1")
                {
                    Console.WriteLine("Muhasebe kullanıcı adınızı giriniz");
                    string kullanici = Console.ReadLine().ToLower();
                    Console.WriteLine("Muhasebe Şifrenizi giriniz");
                    string password = Console.ReadLine().ToLower();

                    if (kullanici=="admin"&& password=="1453")
                    {
                        Console.WriteLine("Yatırılacak tutar miktarı");
                        double tutar = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(tutar);
                        Console.WriteLine($"Muhasebe tarafından {tutar} transfer edilmiştir.");
                    }
                    continue;
                }
                else if (secim=="Q")
                {
                    Console.WriteLine("İyi Günler");
                    Thread.Sleep(2000);
                    break;

                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama");

                }
            }
            while (true)
            {
                Console.WriteLine("Çiflik banka hoşgeldiniz");
                Console.WriteLine("01-Para çekme\n02-Güncel Bakiye\n03-Para Yatırma\n04-Kart iade");
                string cevap = Console.ReadLine();
                if (cevap=="1")
                {
                    Console.WriteLine("Çekmek istediğiniz tutar");
                    double cekicekTutar = Convert.ToDouble(Console.ReadLine());
                    account.WithDraw(cekicekTutar);
                    Console.WriteLine($"Güncel bakiyeniz {account.Balance()}");
                    Thread.Sleep(2000);

                }
                else if (cevap=="2")
                {
                    Console.WriteLine($"Bakiyeniz {account.Balance()}");
                    Thread.Sleep(2000);
                }
                else if (cevap=="3")
                {
                    Console.WriteLine("Yatırmak istediğiniz tutar");
                    double yatirilacakTutar = Convert.ToDouble(Console.ReadLine());

                    account.Deposit(yatirilacakTutar);
                    Console.WriteLine($"Güncel bakiyeniz {account.Balance()}");
                    Thread.Sleep(2000);
                }
                else if (cevap=="4")
                {
                    Console.Clear();
                    Console.WriteLine("Yine bekleriz");
            
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama");
                    Thread.Sleep(2000);
                }

            }

        }
    }
    class BankaAccount
    {
        private double hesap = 20000;
        public double _Hesap//property kapsülleme yapısı
        {
            get { return hesap; }
            set
            {
                if (value>=0)
                {
                    hesap = value;
                }
                else
                {
                    Console.WriteLine("Hesap bakiyesi 0 dan küçük olamaz");
                }
            }
        }

        public void WithDraw(double tutar)//method kapsülleme yapısı
        {
            if (tutar>0&&tutar<=_Hesap)
            {
                _Hesap-=tutar;
                Console.WriteLine($"{tutar} tl çekimi yapıldı güncel hesap {_Hesap}");
            }
            else
            {
                if (tutar<=0)
                {
                    Console.WriteLine("Geçersiz bakiye işlemi");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye");
                }
            }
        }
        public void Deposit(double tutar)
        {
            if (tutar>0)
            {
                _Hesap+=tutar;
            }
            else
            {
                Console.WriteLine("Negatif bir işlem yapılamaz");
            }
        }
        public double Balance()
        {
            return _Hesap;
        }
    }
}
