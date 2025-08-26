using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Encapsulation
{
    internal class Araba
    {
        private double hiz; // private field
        private const double maxHiz = 250; // Sabit maksimum hız

        public double _Hiz
        {
            get { return hiz; }
            set
            {
                if (value >= 0 && value <= maxHiz)// Hız 0 ile maxHiz arasında olmalıdır
                {
                    hiz = value;// Kullanıcı doğru bir değer girdiğinde hiz güncellenir
                }
                else
                {
                    Console.WriteLine($"Hız 0 ile {maxHiz} arasında olmalıdır.");
                    hiz = 0; // Geçersiz hız için varsayılan değer
                }
            }
        }
        public void Hizlanma(double artis)
        {
            hiz+=artis;
            if (hiz>maxHiz)
            {
                hiz=maxHiz;
                Console.WriteLine($"Arabanızın maksimum çıkabileceği hız {this.hiz} km/s olarak ayarlandı ");
            }
          
        }
        public void Yavaslama(double azalis)
        {
            hiz-=azalis;
            if (hiz>=azalis)
            {
                if (hiz==0)
                {
                    Console.WriteLine("Arabanız durdu");
                }
                else if (hiz!=0)
                {
                    Console.WriteLine($"Arabanızın mevcut hızı {hiz}");
                }
            }
            

        }
    }
}
