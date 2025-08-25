using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Class_Object_Static
{
    internal static class SeedClass
    {
        public static void Ekle(List<BuzDolabi> list)
        {
            BuzDolabi b = new BuzDolabi();
            Console.WriteLine("Marka:");
            b.Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            b.Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            b.Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat");
            b.Fiyat=Convert.ToDouble(Console.ReadLine());
            list.Add(b);

        }
        public static BuzDolabi Ekle()
        {
            BuzDolabi b = new BuzDolabi();
            Console.WriteLine("Marka:");
            b.Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            b.Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            b.Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat");
            b.Fiyat=Convert.ToDouble(Console.ReadLine());
            return b;//Sınıf yapısını geriye dönderiyoruz.
        }
    }
}
