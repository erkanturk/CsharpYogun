using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_OOP_Abstraction_3_OdevCozum
{
    public class Gemi : Tasit
    {
        public Gemi(string marka, string model, double tabanFiyat, int kamaraSayisi) : base(marka, model, tabanFiyat)
        {
            KamaraSayisi=kamaraSayisi;
        }
        public int KamaraSayisi { get; set; }

        public override double Fiyat
        {
            get { return TabanFiyat+(KamaraSayisi*40000); 
            }
        }
    }
}
