using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Class_Object_Static
{
    internal class BuzDolabi
    {
        public int id;
        public string Marka;
        public string Model;
        public string Enerji;
        public double Fiyat;

       
        public void Kaydet()
        {
           
            Console.WriteLine("Marka:");
            Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat=Convert.ToDouble(Console.ReadLine());
        }
        public void Kaydet(List<BuzDolabi> list)
        {

            Console.WriteLine("Marka:");
            Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat=Convert.ToDouble(Console.ReadLine());
            list.Add(this);//this buradaki değerleri kaydeder.

        }
       
    }
}
