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
            #region SortedList
            /*Sıralı Liste
             * Sözlük tabanlı bir koleksiyon yapısıdır. İçerisinde Key-Value ilişkisi ile değerleri tutar.
             * Tüm sözlük Tabanlı koleksiyon yapıları IDictonary interface'inden miras almıştır.
             *SortedList e eleman olarak verilen key'ler unique(Benzersiz) olmalıdır.
             *Generic type ile 2 type alır ilki key ikincisi value dur
             *SortedList yapısında Keyler sabittir eğer string olarak verdiysek string devam etmeliyiz.
             *Fakat valuelar istediğimiz tipte olabilir
            
            */
            //SortedList iller = new SortedList();
            //iller.Add(01, "Adana");
            //iller.Add(34, "Istanbul");
            //iller.Add(21, "Diyarbakır");
            //iller.Add(35, "Izmir");
            //iller.Add(37, "Kastamonu");
            //iller.Add(42, "Konya");
            //iller.Add(57, "Sinop");
            //iller.Add(58, "Sivas");
            //iller.Add(32, "Isparta");
            //iller.Add(17, "Canakkale");
            //iller.Add(53, "Rize");
            //iller.Add(61, "Trabzon");
            //iller.Add(81, "Düzce");
            //iller.Add(07, "Antalya");
            //iller.Add(06, "Ankara");
            //iller.Add(16, "Bursa");
            //iller.Add(60, "Tokat");
            //iller.Add(31, "Hatay");
            //iller.Add(05, 05);//Valueları istediğimiz tipte verebiliriz.
            //iller.Add("19", "Kırklareli");//System.InvalidOperationException: 'Failed to compare two elements in the array.'

            //foreach (var item in iller)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*******************");
            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Value+" "+item.Key);
            //}
            //Console.WriteLine(iller.ContainsValue("Adana"));
            //iller[28]="Giresun";//olmayan değeri ekler.
            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //iller[01]="Adana Merkez";//Var olan değeri günceller 
            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //foreach (var item in iller.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in iller.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Value+" "+item.Key);
            //}
            //foreach (var item in iller)
            //{
            //    Console.WriteLine(item);
            //}
            // SortedList<int, string> genericSiraliListe = new SortedList<int, string>();
            // genericSiraliListe.Add(1, "Eren");
            // genericSiraliListe.Add(2, "Tuğba");
            // genericSiraliListe.Add(3, "Zelal");
            // genericSiraliListe.Add(4, "Büşra");
            //// genericSiraliListe.Add(4, 5);Hata veriri çünkü generic bir yapıda belirtilen veri tipinde değerler olmalıdır.
            // foreach (var item in genericSiraliListe)
            // {
            //     Console.WriteLine(item.Value);
            // }
            //SortedList liste = new SortedList()
            //{
            //    {"mavi","blue" },
            //    { "bulutlu","cloudy"}
            //};
            //foreach (DictionaryEntry item in liste)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //foreach (DictionaryEntry item in liste)
            //{
            //    Console.WriteLine(item.Key);
            //}

            #endregion

            #region Ödev SortedList Tr-En Sözlük
            /*
          sözlük uygulaması istenmektedir.Tr - Eng
       sözlük = { "siyah":"black",,,,}
          kullanıcı 4 girene kadar sorulur.
           1 - Arama
           2 - Çıkarma
           3 - Listeleme
           4 - Çıkış

      Kullanıcı 1'e basarsa ->
          - Aranacak olan kelimeyi giriniz:
          -Bu kelime dizide varsa eng karşılığı yazılır.
          -Yoksa uygulamanın gelişmesine yardımcı olmak ister msiniz(E-H):
              -E ise bu kelimenin karşılığı istenir ve sözlüğe eklenir
              -H ise bişey yapılmaz
      Kullanıcı 2'ye basarsa ->
          - Çıkarılmak istenen kelime :
          -Kelime sözlükte varsa çıkartılır
          - Yoksa uyarı verilir.
      Kullanıcı 3'e basarsa ->
          - Tum key value lar listelenir
          -KEY->VALUE
      Kullanıcı 4'e basarsa ->
          - Döngü sonlanır.
           */
            #endregion
            #region HashTable Düzensiz Liste
            /* HashTable:Key Sıralamasının olmadığı ve hızlı key erişimi gerektiğinde ideal olarak kullanılan bir yapıdır
             * HashTable'ın görevi Çok sayıda elemanı key değerlerni kullanarak getirmesidir.
             * Bir key sadece bir kez kullanılır SortedListeki gibi key değerlerinin aynı tipte olması zorunlu değildir.

            
            */
            //Hashtable x = new Hashtable();
            //x.Add(06, "Ankara");
            //x.Add("05", "Amasya");
            //x.Add("Sayi", 10);
            //x.Add(true, false);
            //x.Add(07, "Antalya");
            //x.Add("34", "İstanbul");
            ////foreach (DictionaryEntry item in x)
            ////{
            ////    Console.WriteLine(item.Value+" "+item.Key);
            ////}
            ////x.Remove(true);//Key üzerinden table dan silme işlemi yapar.
            ////foreach (DictionaryEntry item in x)
            ////{
            ////    Console.WriteLine(item.Value+" "+item.Key);
            ////}
            ////Console.WriteLine(x.Count);
            ////Console.WriteLine(x.ContainsValue("antalya"));

            //x["34"]="Kadıköy";
            //x[34]="İstanbul";
            //foreach (DictionaryEntry item in x)
            //{
            //    Console.WriteLine(item.Value+" "+item.Key);
            //}
            #endregion
        }
    }
}
