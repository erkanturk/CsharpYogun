using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_GenericTypes_4
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public DateTime SgkGirisTarihi { get; set; }

        public Personel()
        {
            SgkGirisTarihi= DateTime.Now;
        }
    }
}
