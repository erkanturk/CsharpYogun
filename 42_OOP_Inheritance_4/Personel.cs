using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Inheritance_4
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public DateTime SskGirisTarihi { get; set; }

       
        public Personel()
        {
            SskGirisTarihi = DateTime.Now;
            //Personel sınıfı çağırıldığı gibi ssk giriş tarihi  o anki tarih olarak atanır.
        }
        public void Kaydet()
        {
            Console.WriteLine("Id");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            this.Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            this.Soyad = Console.ReadLine();
            Console.WriteLine("Tc");
            this.TcNo = Console.ReadLine();
        }
    }
}
