using System.Collections;

namespace _31_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> sozluk = new SortedList<string, string>();
            sozluk.Add("mavi", "blue");
            sozluk.Add("beyaz", "white");
            sozluk.Add("siyah", "black");
            sozluk.Add("turuncu", "orange");
            sozluk.Add("yesil", "green");
            sozluk.Add("mor", "pruple");
            sozluk.Add("sari", "yellow");

            while (true)
            {
                Console.WriteLine("1-Arama\n2-Çıkarma\n3-Listeleme\n4-Çıkış\nSeçiminiz:");
                string secim = Console.ReadLine();
                if (secim=="1")
                {
                    Console.WriteLine("Aranacak kelime:");
                    string kelime = Console.ReadLine();
                    if (sozluk.ContainsKey(kelime))
                    {
                        Console.WriteLine(sozluk[kelime]);
                    }
                    else
                    {
                        Console.WriteLine("Sözlükte kelime bulunamadı eklemek ister misiniz?(E/H)");
                        string cevap = Console.ReadLine().ToLower();
                        if (cevap=="e")
                        {
                            Console.WriteLine($"{kelime} kelimesinin ingilizcesini giriniz.");
                            sozluk[kelime] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sen bilirsin!!!");
                        }
                    }
                }
                else if (secim=="2")
                {
                    Console.WriteLine("Çıkarılacak kelime:");
                    string kelime = Console.ReadLine();
                    if (sozluk.ContainsKey(kelime))
                    {
                        sozluk.Remove(kelime);
                    }
                    else
                    {
                        Console.WriteLine("Zaten kelime ekli değil");
                    }
                }
                else if (secim=="3")
                {
                    //KeyValuePair yapısı item değişkeninin ne tipde değerler alacağını belirtecek.
                    foreach (KeyValuePair<string,string> item in sozluk)
                    {
                        Console.WriteLine(item.Value+"=>"+item.Key);
                    }
                }
                else if (secim=="4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim");
                }
            }
        }
    }
}
