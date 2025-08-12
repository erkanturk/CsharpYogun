namespace _15_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays - Diziler
            //Değişkenlerin aksine Index adı verilen numaralandırma yöntemi ile tutulan birden fazla değer tutabilen
            //Koleksiyon yapılarıdır.
            //*** Index numaraları 0 dan başlar ve 1'er 1'er artar.
            // Arrays kendilerina ait metodlara sahiptirler.
            // Array [] ile tanımlanır
            // tek veri tipinde uzunluk kadar eleman tutar
            //veritipi[] değişken adı = new veritipi[uzunluk]
            #region Dizi yapısı
            ////Boş array tanımlama 
            //string[] isimler = new string[5];
            //isimler[0]="Erkan";//1 eleman
            //isimler[1]="Hikmet";//2. eleman
            //isimler[2]="Murat";//3.eleman
            //isimler[3]="Derya";//4.eleman
            //isimler[4]="Reyhan";//5.eleman
            //uzunluğunun -1 i benim index sayımdır.
            //Console.WriteLine(isimler);//bu yapı bana sadece string bir array olduğunu iletir
            //Console.WriteLine(isimler[0]);//yazdırmak istediğimiz index değerini veriyoruz. 0. index 1. eleman
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            ////Dolu array sabit değerler olarak elemanlarını belirtmemiz gerekiyor.
            //string[] adlar = { "Samet", "Halil", "Onur", "Altan", "Yağmur", "Birsu", "Nazlı", "Arhan", "Tuğba", "Mert" };
            ////Console.WriteLine(adlar[3]);//index değerine göre yazdırır.
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i]);
            //}
            //Console.WriteLine("********************");
            //int index = 0;
            //while (index < adlar.Length)
            //{
            //    Console.WriteLine(adlar[index]);
            //    index++;
            //}
            //Console.WriteLine("Foreach başlangıcı");
            //foreach (string ad in adlar)//koleksiyon yapıları içn oluşturulmuş bir döngü yapısıdır.
            //{
            //    Console.WriteLine(ad);
            //}

            //string ad = "Erkan","Türk";//İki değer bir değişkene aktarılamaz 
            //  string ad = "Erkan";//Bu örnekte ad değerini ilk olarak erkan kısmını aldı 
            // ad="Türk";//Sonra türk olarak set edildi yani bir değişken bir değer
            //tutarken bir dizi yapısı birden fazla değeri içinde barındıra bilir.

            #endregion

            #region örnekler
            //int[] sayilar = new int[5];
            //sayilar[0] = 1;
            //sayilar[1]= 2;
            //sayilar[2]= 3;
            //sayilar[3]= 4;
            //sayilar[4]= 5;
            ////sayilar[6]= 6;//IndexOutOfRangeException hatası verir dizi index aşımı

            //for (int i = 0; i<sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.WriteLine(sayilar[3]);
            //string[] adlar = new string[5];
            //foreach (string ad in adlar)//Eğer eleman var ise içerisinde getirir yok ise boş olarak dönderir.
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion

            #region örnek2
            // kullanıcıdan sayilar dizisinin 1 den başlayıp kaca kadar gideceğini soralım ve bu uzunluğa göre her bir değeri diziye aktarsın

            //Console.WriteLine("Dizi yapısı 1 den başlayıp kaça kadar devam etsin belirtin rakamsal olarak");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int[] sayilar = new int[sayi];
            ////sayilar[0] = 1;//manuel yöntem
            ////sayilar[1] = 2;
            ////sayilar[2] = 3;
            ////sayilar[3] = 4;
            ////sayilar[4] = 5;
            ////sayilar[5] = 6;
            //for (int i = 0; i<sayilar.Length; i++)//döngü ile ekleme
            //{
            //    sayilar[i]=i+1;
            //}
            //Console.WriteLine("*************************************");
            //foreach (int s in sayilar)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion
            #region Kullanıcıya kaç adet personeli olduğunu sorunuz
            // verilen cevaba göre her personelin adını sorup diziye aktarınız.
            //Console.WriteLine("Personel Sayınız:");
            //int personelSayi = Convert.ToInt32(Console.ReadLine());
            //string[] personeller = new string[personelSayi];

            //for (int i = 0; i<personeller.Length; i++)
            //{
            //    Console.WriteLine("Personel Adı:");
            //    string ad = Console.ReadLine();

            //    personeller[i]=ad;
            //}
            //Console.WriteLine("**********************");
            //for (int i = 0; i<personeller.Length; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}
            //Console.WriteLine("++++++++++++++++++++++++++");
            //foreach (string bardak in personeller)
            //{
            //    Console.WriteLine(bardak);
            //}

            #endregion

            #region Array Methods
            //!!!!Clear!!!!
            //string[] adlar = { "Ali", "Veli", "Mahmut", "Eren", "Kerem", "Veli" };
            //Array.Clear(adlar);//Adlar dizisinin tüm elemanlarını siler
            //Array.Clear(adlar, 1, 2);//başlangıç index değeri ve uzunluk belirtmemiz gerekiyor
            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            //!!!!Copy!!!!
            //string[] adlar = { "Ali", "Veli", "Mahmut", "Eren", "Kerem", "Veli" };
            //string[] adlar2 = new string[10];
            ////Array.Copy(adlar, adlar2, 3);//Adlar dizisindeki belirtiğimiz sayıdaki elemanı adlar2 ye aktarma işlemi
            //Array.Copy(adlar, 1, adlar2, 2, 3);//Adların 1. indexinden başla ve adlar2 o indexdeki değere aktar.

            //foreach (string ad in adlar2)
            //{
            //    Console.WriteLine(ad);
            //}
            //!!!!IndexOf!!!!
            //string[] adlar = { "Ali", "Veli", "Mahmut", "Eren", "Kerem", "Veli","Arhan","Kamil","Erkan","Veli" };
            //// int index = Array.IndexOf(adlar, "Veli");//ilk bulduğu index i getirir.
            ////Console.WriteLine(index);
            ////Console.WriteLine(adlar[index]);
            //int index = Array.IndexOf(adlar,"Veli");
            //int index2 = Array.IndexOf(adlar, "Veli", index+1);
            ////ilk bulunan indexde ki değeri es geç ve ondan sonra arama yapmaya başla diyoruz.
            //Console.WriteLine(index);
            //Console.WriteLine(index2);

            //!!!!LastIndexOf!!!!
            //string[] adlar = { "Ali", "Veli", "Mahmut", "Eren", "Kerem", "Veli", "Arhan", "Kamil", "Erkan", "Veli" };
            //int index = Array.LastIndexOf(adlar, "Veli");//verdiğim değeri sondan itibaren aramaya başlar.
            //Console.WriteLine(index);
            //int index2 = Array.LastIndexOf(adlar, "Veli",index-1);//lastindexof yapısında - li ilerleriz 
            ////indexof da + ile ilerleriz.
            //Console.WriteLine(index2);

            //!!!!Sort ve Reverse!!!
            //string[] adlar = { "Ali", "Veli", "Mahmut", "Eren", "Kerem", "Veli", "Arhan", "Kamil", "Erkan", "Veli" };
            ////Sort A->Z ye sıralama yapar 
            //int[] sayilar = { 99, 33, 55, 60, 22, 10, 11, 12, 5, 6, 5, 3, 4 };
            ////Array.Sort(adlar);//Alfabetik sıralar
            ////Array.Sort(sayilar);//küçükten büyüğe sıralar.
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            //Array.Reverse(adlar);//Reverse Var olan elemanları tersten sıralar.
            //Array.Reverse(sayilar);
            //Console.WriteLine("****************");
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            //Console.WriteLine("****************");
            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            //!!!!Resize!!!!
            //int[] sayilar = new int[5];
            //sayilar[0] = 1;
            //sayilar[1]= 2;
            //sayilar[2]= 3;
            //sayilar[3]= 4;
            //sayilar[4]=5;
            //Ref Daha önce tanımlanmış bir değeri revize etmek güncellemek için kullandığımız keywordür.
            //Out: Daha önce tanımlanmamış bir değere değer ataması için kullanırız.
            //Array.Resize(ref sayilar, 8);//yeni boyut miktarını uzunluk olarak belirtiriz.
            //Array.Resize(ref sayilar, sayilar.Length+1);//Uzunluğu 5 olan bir değerin +1 dediğimizde 6 ya çıkarır.
            //sayilar[5]= 6;
            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //string sayi = "test";
            ////Console.WriteLine(sayi+50);
            //int s;//okul açtım ve öğretmen yok okulda
            //int.TryParse(sayi, out s);//okula bir öğretmen ataması yaptım
            //Console.WriteLine();

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //string sayi = Console.ReadLine();
            //int number;
            //if (int.TryParse(sayi, out number))
            //{
            //    Console.WriteLine("sayısal değer"+number);
            //}
            //else
            //{
            //    Console.WriteLine(sayi);
            //}

            Console.WriteLine("1.Sayıyı giriniz");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi belirtin \n01'topla'\n02'cikar'\n03'carp'\n04'bol'");
            string islem = Console.ReadLine().ToLower();
            int i;
            if (int.TryParse(islem, out i))
            {
                if (i==01)
                {
                    Console.WriteLine(sayi1+sayi2);
                }
                else if (i==02)
                {
                    Console.WriteLine(sayi1-sayi2);
                }
                else if (i==03)
                {
                    Console.WriteLine(sayi1*sayi2);
                }
                else if (i==04)
                {
                    if (sayi2!=0)
                    {
                        Console.WriteLine(sayi1/sayi2);
                    }
                    else
                    {
                        Console.WriteLine("Sayı 0 a bölünemez");
                    }
                }
            }
            else
            {
                if (islem=="topla")
                {
                    Console.WriteLine(sayi1+sayi2);
                }
                else if (islem=="cikar")
                {
                    Console.WriteLine(sayi1-sayi2);
                }
                else if (islem=="carp")
                {
                    Console.WriteLine(sayi1*sayi2);
                }
                else if (islem=="bol")
                {
                    if (sayi2!=0)
                    {
                        Console.WriteLine(sayi1/sayi2);
                    }
                    else
                    {
                        Console.WriteLine("Sayı 0 a bölünemez");
                    }
                }
            }


            #endregion

            //Kaynaklar
            //https://roadmap.sh/
            //https://medium.com/
            //https://stackoverflow.com/
        }
    }
}
