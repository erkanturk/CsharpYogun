using System.Collections;

namespace _30_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList 
             * Arraylistler içerisinde sınırsız sayıda her değeri barındıran bir liste yapısıdır
             * Uzunluk miktarı 2 üzeri n diye adlandırılır bir sınırı yoktur diyebiliriz.
             * Yapıyı tanımlarken bir veri tipi veya bir uzunluk belirtmemize gerek yoktur
             * Tüm yapıları içerisinde barındırabilir ve her bir yapı listenin elemanı içerisinde indexlerle tutulur.
            int[] int =new int[uzunluk];
            Arraylist gelen değerlerin her birini otomatik olarak resize ile liste aşımını engelleyerek 
            listenin uzunluğunu arttırır
            */
            #region Boş Array Oluşturma FiFo (First in First Out)
            //ArrayList arrayList = new ArrayList();//Boş bir array yapısı
            //arrayList.Add("10");//Tekli Ekleme yöntemi
            //arrayList.Add(20);
            //arrayList.Add(33.5);
            //arrayList.Add(true);
            //arrayList.Add(false);
            //arrayList.Add(DateTime.Now);
            //arrayList.Add('a');

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Dolu ArrayList
            //ArrayList list = new ArrayList() { "ali", "Ahmet", true, false, 30.5, 30, DateTime.Now };
            //list.Add("Erkan");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(list.Count);//eleman sayısını verir
            //Console.WriteLine(list.Capacity);//listenin kapasitesini verir.
            //list.Add("test");
            //Console.WriteLine(list.Capacity);//2 üzeri n olarak resize işlemi yapar arka planda
            //Console.WriteLine("*********************");
            //list[0]="Veli";//Belirtiğimiz index'i güncelleme işlemi.
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList sayiList = new ArrayList() { };

            //for (char i = 'A'; i <= 'z'; i++)
            //{

            //    sayiList.Add(i);//Tekli ekleme

            //}
            //sayiList.AddRange(new ArrayList { "Test", 20, 30, 40, 60, true, false });//Çoklu ekleme yöntemi
            //foreach (var item in sayiList)
            //{
            //    Console.WriteLine(item);
            //}
            //ArrayList sayiList = new ArrayList();
            //int[] sayilar = { 1, 2, 3, 4, 5, };
            //sayiList.AddRange(new ArrayList { sayilar[0], sayilar[1], sayilar[2], sayilar[4] });//Diziden ArrayListe aktarma
            //sayiList.AddRange(sayilar);//Diziden ArrayListe aktarma
            //foreach (var item in sayiList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region ArrayListMethod
            //ArrayList list = new ArrayList();
            ////list.Add(10);//Tekli ekleme
            ////list.AddRange(new ArrayList { 10, 20, 30, 40 });//Çoklu ekleme
            //////Insert: istenilen index e değer eklememizi sağlar

            ////list.Insert(0, 99);
            //////foreach (var item in list)
            //////{
            //////    Console.WriteLine(item);
            //////}

            //////list.Clear();//Listenin tüm elemanlarını siler
            //////Dondur(list);
            //list.InsertRange(1, new ArrayList { "Hakan", "Emre", "Ahmet", "Mehmet", "Emre", "Erkan", "Emre" });
            //İstediğimiz indexden başlayarak istediğimiz uzunlukta ekleme
            //Dondur(list);

            ////Remove 
            ////list.Remove("Emre");//içindeki elemana göre silme
            ////Dondur(list);
            //Console.WriteLine("**********");
            //Console.WriteLine(list[5]);
            //list.RemoveAt(5);//listenin index değerinde bulunan elemanı siler.
            //Dondur(list);
            //Dondur(list);
            //Console.WriteLine("Silme işlemi sonrası");
            //list.RemoveRange(1, 3);//ilk değer index değeri belirtiğim indexden başla ve belirtiğim uzunluğa kadar sil 
            //Dondur(list);

            //IndexOf
            //ArrayList arrayList = new ArrayList { 99, 22, 33, 10, "Hakan", "Emre", "Ahmet", "Mehmet", "Emre", "Erkan", "Emre" };
            //ArrayList sayiList = new ArrayList() { 10, 20, 30, 40, 1, 2, 3, 4, 5 };
            ////Console.WriteLine(arrayList.IndexOf("Emre"));//Listenin içinde belirtiğimiz value nun ilk bulduğu indexi getirir.
            ////Console.WriteLine(arrayList.IndexOf("Emre",2));//Listenin içinde belirtiğimiz value nun
            ////belirtiğimiz indexten itibaren bakarak  ilk bulduğu indexi getirir.
            ////LastIndexOf
            //Console.WriteLine(arrayList.LastIndexOf("Emre"));//Sondan bakarak listenin içindeki elemanın indexi ni getirir
            //Console.WriteLine(arrayList.LastIndexOf("Emre",5));//belirtiğim indexten bakarak sondaki
            //                                                   //en yakın verdiğim değerin indexini getirir
            ////Reverse tersine çevirme
            //arrayList.Reverse();

            //Dondur(arrayList);
            ////Sıralama işlemi

            //sayiList.Sort();//Sayısal tip de varsa bu yapı patlar
            //Dondur(sayiList);

            //Console.WriteLine(sayiList.Contains(10));


            #endregion
            //!!!Kullanıcıdan sayı isteyelim Sayı verdiği sürecede toplama
            //yapalım sayı yerine "çık" yazarsa toplama işlemi yapalım girilen tüm sayıların toplamını
            ////Hemde girilen sayılar.
            //int toplam = 0;
            //ArrayList list = new ArrayList();
            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    string sayi = Console.ReadLine();

            //    if (sayi.ToLower()=="çık")
            //    {
            //        break;
            //    }
            //    int deger = Convert.ToInt32(sayi);
            //    list.Add(deger);
            //    toplam+=deger;
            //}

            //Console.WriteLine("Sayıların Toplamı: "+toplam);
            //foreach (var i in list)
            //{
            //        Console.WriteLine(i);
            //}
            //if(true)//Scopesuz kullanım
            //    Console.WriteLine("test");
            ArrayList list = new ArrayList() { 5, 15, "Test", "25", 1, 2, 3, 4, 5, };
            ////Console.WriteLine(list.Contains("25") ? "Var" : "Yok");//? işaresi if yapısı olarak kullanılır : ise else kısmıdır.
            //ArrayList list2 = (ArrayList)list.Clone();//dolu bir ArrayList yapısından boş bir ArrayList yapısına kopyalama
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] sayi = { 10, 20, 30, 40 ,6,7 };
            //int[] sayi2 = new int[sayi.Length];
            //Array.Copy(sayi, sayi2, 6);
            //foreach (var item in sayi2)
            //{
            //    Console.WriteLine(item);
            //}
            ArrayList list3 = new ArrayList();
            list3.AddRange(list);
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
        }
        static void Dondur(ArrayList list)
        {
            Console.WriteLine("***********");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}
