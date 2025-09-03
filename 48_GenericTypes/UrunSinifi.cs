using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_GenericTypes
{
    //T:Generic Parametredir.
    //Nesne üretilirken tipi mutlaka söylenmek zorundadır Tipleri(int,string,Datetime,bool Class vb. olabilir. )
    internal class UrunSinifi<T>
    {
        //T tipi clas tasarımında her yerde kullanılabilir. Method,ctor,property,dahildir. field olarak düşünmek gerekir.
        public T Fiyat { get; set; }
        public T Kdv { get; set; }
        public UrunSinifi(T fiyat,T kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }
    }
}
