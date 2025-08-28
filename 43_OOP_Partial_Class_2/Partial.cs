using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_Partial_Class_2
{
    partial class Partial
    {
        //Partial methodlar , gövdesiz şekilde kod tarafında yazılır. 
        //Ancak bı yazım şekli abstract methodlar ile karışaltırılmamalıdır!
        //abstract method:gövdesi olmayan method
        //partial method : gövdesi olmadan yazılır ancak;
        //bu şekilde yazılan methodlar tanımlanmamış sayılmazlar! diğer bir değişle bu method şu anda hiç yazılmamış gibidir.
        partial void Test1();
        partial void Test2();

        public void ErisilebilirMethod()
        {
            Test1 ();
            Test2 ();
        }
    }
}
