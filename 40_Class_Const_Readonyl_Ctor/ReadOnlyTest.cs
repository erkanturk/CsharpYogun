using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Class_Const_Readonyl_Ctor
{
    internal class ReadOnlyTest
    {
        private readonly int Deger = 10;

        public ReadOnlyTest()
        {
            Deger = 20; //readonly yapısı constructor içinde değer ataması yapılabilir
        }
        //public void test()
        //{
        //    Deger=30;//readonly yapısı Sadece okuma işlemi yapar
        //    this.Deger=20;//readonly yapısı Sadece okuma işlemi yapar
        //}
    }
}
