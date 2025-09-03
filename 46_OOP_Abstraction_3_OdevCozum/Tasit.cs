using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_OOP_Abstraction_3_OdevCozum
{
    public abstract class Tasit
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double TabanFiyat { get; set; }
        public abstract double Fiyat { get; }

        protected Tasit(string marka,string model,double tabanFiyat)
        {
            Marka = marka;
            Model = model;
            TabanFiyat = tabanFiyat;
        }
    }
}
