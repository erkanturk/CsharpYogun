using System.Collections;
using System.Collections.Generic;

namespace _48_GenericTypes_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BilgiIslem bilgiIslem = new BilgiIslem();

            //bilgiIslem.Insert(bilgiIslem);

            //InsanKaynaklari ik = new InsanKaynaklari();
            //int[] dizi = { 1, 2 };
            //Console.WriteLine(dizi);//Gelen dizinin bize hangi tipte olduğunu belirtir.
            SortedList sorted = new SortedList();
            sorted["test"]=10;
            sorted["test1"]="10";
            sorted["test12"]='A';
            sorted["test13"]=true;
            foreach (DictionaryEntry item in sorted)
            {
                Console.WriteLine(item.Key+" "+item.Key);
            }
            SortedList<char, string> generic = new SortedList<char, string>();

           

        }
    }
}
