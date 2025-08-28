using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Polymorphism_3
{
    internal class Balik:Canli
    {
        //Base classta bu yapı virtual olduğu için (override) olarak
        //ben bu yapıyı ezip kendime uygun bir 
        //biçime getirdim.
        public override void HaketEt()
        {
            Console.WriteLine("Ben balığım yüzerim");
        }
    }
}
