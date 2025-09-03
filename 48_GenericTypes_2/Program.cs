namespace _48_GenericTypes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun<int> urun = new Urun<int>(100, 200);
            Urun<int, double> urun1 = new Urun<int, double>(100, 200.5);

            Urun<string, char> urun2 = new Urun<string, char>("qweqweqe", 'A');

            Urun<double, string> urun3 = new Urun<double, string>(200.50, "Kdv dahil fiyat");
            Console.WriteLine(urun3.Value+" "+urun3.Value2);
        }
    }
}
