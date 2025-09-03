using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_OOP_Abstraction_3_OdevCozum
{
    public class Ucak : Tasit
    {
        public Ucak(string marka, string model, double tabanFiyat,int kapasite) : base(marka, model, tabanFiyat)
        {
            Kapasite = kapasite;
        }
        public int Kapasite { get; set; }

        public override double Fiyat { get { return TabanFiyat+(Kapasite*100); } 
        }
    }
}
