using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Inheritance_4
{
    internal class BilgiIslem : Personel
    {
        public int Id;
        public int ProgramSayisi;

        public void BilgiIslemEkle()
        {
            //base.Id= base ıd personel sınıfındaki Id propertysidir
            //this.Id= this ıd bilgi işlem sınıfındaki Id propertysidir
            ProgramSayisi+=5;
        }
    }
}
