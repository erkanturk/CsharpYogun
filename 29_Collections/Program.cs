using System.Collections;

namespace _29_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collection 
            /* Arraylere benzer olarak içerisinde birden çok yapıyı barındıran data yapılarıdır.
            string[] int[] char[] gibi arrayler içerisinde sadece ilgili data tipini tutarken
            Collection yapıları daha spesifik ve karmaşık yapılarla beraber birden çok data tipini içinde barındırır
            ICollection=>koleksiyon yapıları=>ArrayList,Stack,Queue,SortedList,HashTable,List(Generic)
            System.Collection yapısından türeyen yapılardır.

             */
            #region Queue Kuyruk çalışma prensibi Fifo prensibidir. Dinamik bir yapıdadır.
            //First in First out İlk giren ilk çıkar.
            //Queue queue = new Queue();//Boş bir kuyruk oluşturma yapısıdır.
            //queue.Enqueue("Erkan");//İlk giren ilk çıkar.
            //queue.Enqueue("Altan");
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue('B');


            ////queue.Clear();//hepsini siler
            // //queue.Dequeue();//Kuyruktaki ilk elemanı kuyruktan çıkarır.

            ////Console.WriteLine(queue.Peek());//Peak bize kuyruktaki ilk elemanı verir.
            ////foreach (var item in queue)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(queue.Count);//kuyruğun içindeki elemanları bize gösterir.

            //Queue queue = new Queue();
            //queue.Enqueue("Ali");//kuyruğa ekleme yapar.
            //queue.Enqueue("Veli");
            //queue.Enqueue("Ahmet");
            //queue.Enqueue("Arda");
            //queue.Enqueue("Altan");
            //for (int i = 5; i>=queue.Count; i--)
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine($"{i}.Sıradasınız");
            //    if (queue.Count==1)
            //    {
            //        Console.WriteLine("Sıra Sizde "+queue.Peek());
            //    }
            //    else
            //    {
            //        queue.Dequeue();//Dequeue kuyruktan çıkarma işlemi yapar ilk sıradaki elemanı siler
            //    }
            //}

            #endregion
            #region Stack Yığın Yapısı Prensibi Lifo (Last in First Out) Son giren ilk  çıkar.Dinamik bir yapıdadır.
            Stack stack = new Stack();
            stack.Push("Erkan");//ekleme işlemi
            stack.Push("Altan");
            stack.Push(10);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(stack.Count);

            //object sonEleman = stack.Pop();//Silme işlemi yapar.
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("************");
            //Console.WriteLine(stack.Peek());//ilk elemanını yazdırır.

            //Console.WriteLine(stack.Contains("Erkan"));//Contains(); Girdiğimiz değer içinde var ise true döner yoksa false döner

            //stack.Clear();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
