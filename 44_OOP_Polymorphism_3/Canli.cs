using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Polymorphism_3
{
    internal class Canli
    {
        //Parrent sınıfta virtual olarak işaretlenen yapı diğer child sınıflarda ezilebilir.
        public virtual void HaketEt()
        {
            Console.WriteLine("Canlıyım hareket ederim");
        }
    }
}
