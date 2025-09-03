using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_OOP_Abstraction_3_OdevCozum
{
    public class Tren : Tasit
    {
        public Tren(string marka, string model, double tabanFiyat, int vagonSayisi, string sinif) : base(marka, model, tabanFiyat)
        {
            VagonSayisi=vagonSayisi;
            Sinif=sinif;
        }
        public int VagonSayisi { get; set; }
        public string Sinif {  get; set; }
        public override double Fiyat { get { if (Sinif=="A") 
                    TabanFiyat+=5000; 
                else if (Sinif=="B") 
                    TabanFiyat+=10000;
                return TabanFiyat+(VagonSayisi*30000); } 
        }
    }
}
